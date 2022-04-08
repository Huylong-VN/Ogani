using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Ogani.Data;
using Ogani.Models;
using Ogani.Service;
using Ogani.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ogani.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OganiDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ILogger<HomeController> logger, OganiDbContext dbContext, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string keyword, Guid CategoryId, string sorting = null, int p = 1, int s = 8)
        {
            ViewBag.Categories = _dbContext.Categories.ToList();
            ViewBag.blogRecent = _dbContext.Blogs.OrderByDescending(x => x.CreateAt).Take(3);
            var query = _dbContext.Products.Include(x => x.ProductImages).Include(x => x.ProductCategories).
                ThenInclude(x => x.Category).AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.Name.Contains(keyword) || x.Description.Contains(keyword) ||
                x.CurrentPrice.Contains(keyword));
            }
            if (!string.IsNullOrWhiteSpace(sorting) && !sorting.StartsWith("-"))
            {
                query = sorting switch
                {
                    nameof(Product.Name) => query.OrderBy(x => x.Name),
                    nameof(Product.Description) => query.OrderBy(query => query.Description),
                    nameof(Product.ToTalRemaining) => query.OrderBy(x => x.ToTalRemaining),
                    nameof(Product.CurrentPrice) => query.OrderBy(x => x.CurrentPrice),
                    nameof(Product.ReducePrice) => query.OrderBy(x => x.ReducePrice),
                    _ => query.OrderBy(x => x.CreateAt),
                };
            }
            else
            {
                query = sorting switch
                {
                    "-" + nameof(Product.Name) => query.OrderByDescending(x => x.Name),
                    "-" + nameof(Product.Description) => query.OrderByDescending(query => query.Description),
                    "-" + nameof(Product.ToTalRemaining) => query.OrderByDescending(x => x.ToTalRemaining),
                    "-" + nameof(Product.CurrentPrice) => query.OrderByDescending(x => x.CurrentPrice),
                    "-" + nameof(Product.ReducePrice) => query.OrderByDescending(x => x.ReducePrice),
                    _ => query.OrderByDescending(x => x.CreateAt),
                };
            }
            if (CategoryId != Guid.Empty)
            {
                query = query.Where(x => x.ProductCategories.Any(x => x.CategoryId == CategoryId));
            }
            var result = await query.Skip((p - 1) * s).Take(s).ToListAsync();
            ViewBag.Feature = result;
            ViewBag.Rate = query.OrderBy(x => x.Rate).Take(10);

            // later
            var LatesProduct = new List<List<Product>>();
            var pr = new List<Product>();
            int i = 0;
            foreach (var product in query.OrderByDescending(x => x.CreateAt).Take(9))
            {
                i++;
                pr.Add(product);
                if (i == 3)
                {
                    LatesProduct.Add(new List<Product>(pr));
                    pr.RemoveRange(0, 3);
                    i = 0;
                }
            }
            if (pr.Count > 0) LatesProduct.Add(pr);
            ViewBag.latestProduct = LatesProduct;

            //rated
            var ratedProduct = new List<List<Product>>();
            var rp = new List<Product>();
            int j = 0;
            foreach (var product in query.OrderByDescending(x => x.Rate).Take(9))
            {
                j++;
                rp.Add(product);
                if (j == 3)
                {
                    ratedProduct.Add(new List<Product>(rp));
                    rp.RemoveRange(0, 3);
                    j = 0;
                }
            }
            if (rp.Count > 0) ratedProduct.Add(rp);
            ViewBag.ratedProduct = ratedProduct;

            //end
            var favoritedProduct = new List<List<Product>>();
            var fp = new List<Product>();
            int k = 0;
            foreach (var product in query.OrderByDescending(x => x.CurrentPrice).Take(9))
            {
                k++;
                fp.Add(product);
                if (k == 3)
                {
                    favoritedProduct.Add(new List<Product>(fp));
                    fp.RemoveRange(0, 3);
                    k = 0;
                }
            }
            if (fp.Count > 0) favoritedProduct.Add(fp);
            ViewBag.favoritedProduct = favoritedProduct;

            return View(new PagedResultBase()
            {
                PageIndex = p,
                Keyword = keyword,
                PageSize = s,
                TotalRecords = query.Count()
            });
        }

        public IActionResult Contact()
        {
            return View();
        }

        [Authorize]
        public IActionResult Checkout(string total)
        {
            ViewBag.Total = total;
            return View();
        }

        public async Task<IActionResult> ShopDetail(Guid Id)
        {
            var product = await _dbContext.Products.Include(x => x.Supplier).Include(x => x.ProductCategories).ThenInclude(x => x.Category).FirstOrDefaultAsync(x => x.Id.Equals(Id));
            if (product != null)
            {
                ViewBag.ProductReLated = _dbContext.Products.Where(x => x.Id.Equals(Id) == false).Take(4).ToList();
                ViewBag.ImageDetail = _dbContext.ProductImages.Where(x => x.ProductId.Equals(Id));
                return View(product);
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> ShoppingGridAsync(string keyword, Guid CategoryId, string sorting = null, int p = 1, int s = 6)
        {
            ViewBag.Categories = _dbContext.Categories.ToList();
            ViewBag.Favorite = await _dbContext.Products.Include(x => x.Supplier).
                Include(x => x.ProductCategories).ThenInclude(x => x.Category).OrderBy(x => x.Rate).Take(6).ToListAsync();

            var query = _dbContext.Products.Include(x => x.ProductImages).Include(x => x.ProductCategories).
              ThenInclude(x => x.Category).AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.Name.Contains(keyword) || x.Description.Contains(keyword) ||
                x.CurrentPrice.Contains(keyword));
            }
            if (CategoryId != Guid.Empty)
            {
                query = query.Where(x => x.ProductCategories.Any(x => x.CategoryId == CategoryId));
            }
            if (!string.IsNullOrWhiteSpace(sorting) && !sorting.StartsWith("-"))
            {
                query = sorting switch
                {
                    nameof(Product.Name) => query.OrderBy(x => x.Name),
                    nameof(Product.Description) => query.OrderBy(query => query.Description),
                    nameof(Product.ToTalRemaining) => query.OrderBy(x => x.ToTalRemaining),
                    nameof(Product.CurrentPrice) => query.OrderBy(x => x.CurrentPrice),
                    nameof(Product.ReducePrice) => query.OrderBy(x => x.ReducePrice),
                    _ => query.OrderBy(x => x.CreateAt),
                };
            }
            else
            {
                query = sorting switch
                {
                    "-" + nameof(Product.Name) => query.OrderByDescending(x => x.Name),
                    "-" + nameof(Product.Description) => query.OrderByDescending(query => query.Description),
                    "-" + nameof(Product.ToTalRemaining) => query.OrderByDescending(x => x.ToTalRemaining),
                    "-" + nameof(Product.CurrentPrice) => query.OrderByDescending(x => x.CurrentPrice),
                    "-" + nameof(Product.ReducePrice) => query.OrderByDescending(x => x.ReducePrice),
                    _ => query.OrderByDescending(x => x.CreateAt),
                };
            }
            var result = await query.Skip((p - 1) * s).Take(s).ToListAsync();
            ViewBag.Products = result;
            var LatesProduct = new List<List<Product>>();
            var pr = new List<Product>();
            int i = 0;
            foreach (var product in query.OrderByDescending(x => x.CreateAt).Take(6))
            {
                i++;
                pr.Add(product);
                if (i == 3)
                {
                    LatesProduct.Add(new List<Product>(pr));
                    pr.RemoveRange(0, 3);
                    i = 0;
                }
            }
            if (pr.Count > 0) LatesProduct.Add(pr);
            ViewBag.latestProduct = LatesProduct;
            ViewBag.Rate = query.OrderBy(x => x.Rate).Take(10);
            return View(new PagedResultBase()
            {
                PageIndex = p,
                Keyword = keyword,
                PageSize = s,
                TotalRecords = query.Count()
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart()
        {
            Guid productId = new Guid(Request.Form["productId"]);
            int quantity = int.Parse(Request.Form["quantity"]);
            if (quantity == null) quantity = 1;
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = _dbContext.Products.Find(productId), Quantity = quantity });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(productId);
                if (index != -1 && quantity == null)
                {
                    cart[index].Quantity++;
                }
                else if (index != -1 && quantity != null)
                {
                    cart[index].Quantity += quantity;
                }
                else
                {
                    cart.Add(new Item { Product = _dbContext.Products.Find(productId), Quantity = quantity });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            HttpContext.Session.SetString("toTal", SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart").Count.ToString());

            HttpContext.Session.SetString("toTalPrice", SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart").Sum(x => (long)Convert.ToDouble(x.Product.CurrentPrice) * x.Quantity).ToString());

            return Redirect(HttpContext.Request.Headers["Referer"].ToString());
        }

        [HttpGet]
        public async Task<IActionResult> AddToCart(Guid productId)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = _dbContext.Products.Find(productId), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(productId);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = _dbContext.Products.Find(productId), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            HttpContext.Session.SetString("toTal", SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart").Count.ToString());

            HttpContext.Session.SetString("toTalPrice", SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart").Sum(x => (long)Convert.ToDouble(x.Product.CurrentPrice) * x.Quantity).ToString());

            return Redirect(HttpContext.Request.Headers["Referer"].ToString());
        }

        private int isExist(Guid id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        public IActionResult RemoveFromCart(Guid id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
               HttpContext.Session.SetString("toTal", SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart").Count.ToString());

            HttpContext.Session.SetString("toTalPrice", SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart").Sum(x => (long)Convert.ToDouble(x.Product.CurrentPrice) * x.Quantity).ToString());
            return RedirectToAction(nameof(ShoppingCart));
        }

        public IActionResult ShoppingCart()
        {
            List<Item> product = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.Cart = product;
            if (product != null)
            {
                ViewBag.Total = HttpContext.Session.GetString("toTalPrice");
            }
            return View(product);
        }

        public async Task<IActionResult> BlogView(string keyword, string sorting = null, int p = 1, int s = 6)
        {
            var query = _dbContext.Blogs.Include(x => x.AppUser).ThenInclude(x => x.AppUserRoles).ThenInclude(x => x.AppRole).AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x => x.Title.Contains(keyword) || x.Content.Contains(keyword) ||
                x.AppUser.LastName.Contains(keyword));
            }
            if (!string.IsNullOrWhiteSpace(sorting) && !sorting.StartsWith("-"))
            {
                query = sorting switch
                {
                    nameof(Blog.Title) => query.OrderBy(x => x.Title),
                    nameof(Blog.Content) => query.OrderBy(query => query.Content),
                    _ => query.OrderBy(x => x.CreateAt),
                };
            }
            else
            {
                query = sorting switch
                {
                    "-" + nameof(Blog.Title) => query.OrderByDescending(x => x.Title),
                    "-" + nameof(Blog.Content) => query.OrderByDescending(query => query.Content),
                    _ => query.OrderByDescending(x => x.CreateAt),
                };
            }
            var result = await query.Skip((p - 1) * s).Take(s).ToListAsync();
            ViewBag.Blogs = result;

            ViewBag.blogRecent = _dbContext.Blogs.OrderByDescending(x => x.CreateAt).Take(3);
            return View(new PagedResultBase()
            {
                PageIndex = p,
                Keyword = keyword,
                PageSize = s,
                TotalRecords = query.Count()
            });
        }

        public async Task<IActionResult> BlogDetail(Guid Id)
        {
            var blog = _dbContext.Blogs.Include(x => x.AppUser).ThenInclude(x => x.AppUserRoles).ThenInclude(x => x.AppRole).FirstOrDefault(x => x.Id.Equals(Id));

            ViewBag.blogRecent = _dbContext.Blogs.OrderByDescending(x => x.CreateAt).Take(3);

            ViewBag.Ralated = _dbContext.Blogs.Where(x => x.Id.Equals(Id) == false);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // Payment
        [Authorize]
        public async Task<ActionResult> Payment()
        {
            var user = await _userManager.GetUserAsync(User);
            Order or = new Order()
            {
                CreateAt = DateTime.Now,
                Email = Request.Form["email"],
                FirstName = Request.Form["firstName"],
                LastName = Request.Form["lastName"],
                Id = Guid.NewGuid(),
                Phone = Request.Form["phone"],
                Total = Request.Form["total"],
                UserId = user.Id,
                Address = Request.Form["address"],
                Method = Request.Form["method"]
            };
            string amount = (int.Parse(or.Total) * 22839).ToString();
            string orderInfo = "Payment Product";
            await _dbContext.Orders.AddAsync(or);
            List<Item> product = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            foreach (var p in product)
            {
                await _dbContext.ProductOrders.AddAsync(new ProductOrder()
                {
                    OrderId = or.Id,
                    ProductId = p.Product.Id,
                    Quantity = p.Quantity
                });
            }

            if (Request.Form["method"].Equals("0"))
            {
                HttpContext.Session.Remove("cart");
                HttpContext.Session.Remove("toTal");
                HttpContext.Session.Remove("toTalPrice");
                return RedirectToAction(nameof(ConfirmPaymentClient));
            }
            //request params need to request to MoMo system
            string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
            string partnerCode = "MOMOZLPF20220110";
            string accessKey = "n3sNUZ77wfW6nDqr";
            string serectkey = "v1gAA5mofQ0clCkGy8sBXanfWfRMEHai";
            string returnUrl = "https://backend-api37.herokuapp.com/Home/ConfirmPaymentClient";
            string notifyurl = "https://backend-api37.herokuapp.com/Home/SavePayment"; //lưu ý: notifyurl không được sử dụng localhost, có thể sử dụng ngrok để public localhost trong quá trình test

            string orderid = or.Id.ToString();
            string requestId = DateTime.Now.Ticks.ToString();
            string extraData = "";

            //Before sign HMAC SHA256 signature
            string rawHash = "partnerCode=" +
                partnerCode + "&accessKey=" +
                accessKey + "&requestId=" +
                requestId + "&amount=" +
                amount + "&orderId=" +
                orderid + "&orderInfo=" +
                orderInfo + "&returnUrl=" +
                returnUrl + "&notifyUrl=" +
                notifyurl + "&extraData=" +
                extraData;

            MoMoSecurity crypto = new MoMoSecurity();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "accessKey", accessKey },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderid },
                { "orderInfo", orderInfo },
                { "returnUrl", returnUrl },
                { "notifyUrl", notifyurl },
                { "extraData", extraData },
                { "requestType", "captureMoMoWallet" },
                { "signature", signature }
            };

            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

            JObject jmessage = JObject.Parse(responseFromMomo);

            return Redirect(jmessage.GetValue("payUrl").ToString());
        }

        //Khi thanh toán xong ở cổng thanh toán Momo, Momo sẽ trả về một số thông tin, trong đó có errorCode để check thông tin thanh toán
        //errorCode = 0 : thanh toán thành công (Request.QueryString["errorCode"])
        //Tham khảo bảng mã lỗi tại: https://developers.momo.vn/#/docs/aio/?id=b%e1%ba%a3ng-m%c3%a3-l%e1%bb%97i
        public ActionResult ConfirmPaymentClient(int errorCode)
        {
            //hiển thị thông báo cho người dùng
            if(errorCode == 0)
            {
                HttpContext.Session.Remove("cart");
                HttpContext.Session.Remove("toTal");
                HttpContext.Session.Remove("toTalPrice");
                TempData["mess"] = "Order SuccessFully";
            }
            else
            {
                TempData["mess"] = "Order Failed";
            }
            return View();
        }

        [HttpPost]
        public async void SavePayment()
        {
            await _dbContext.SaveChangesAsync();
            //cập nhật dữ liệu vào db
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
