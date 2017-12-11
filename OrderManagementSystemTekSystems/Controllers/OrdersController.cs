using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OrderManagementSystemTekSystems.DAL;
using OrderManagementSystemTekSystems.Models;

namespace OrderManagementSystemTekSystems.Controllers
{
    public class OrdersController : Controller
    {
        private IOrderRepository OrderRepository;

      public OrdersController()
        {
            this.OrderRepository = new OrderRepository(new OrderContext());
        }

        public OrdersController(IOrderRepository orderRepository)
        {
            this.OrderRepository= orderRepository;
        }
        
        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = OrderRepository.GetOrderByID(id.Value);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OrderType,AccountNumber,CustomerName")] Order order)
        {
            if (ModelState.IsValid)
            {
                OrderRepository.InsertOrder(order);
                OrderRepository.Save();
                return RedirectToAction("Index");
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = OrderRepository.GetOrderByID(id.Value);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OrderType,AccountNumber,CustomerName")] Order order)
        {
            if (ModelState.IsValid)
            {
                OrderRepository.UpdateOrder(order);
                OrderRepository.Save();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = OrderRepository.GetOrderByID(id.Value);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderRepository.DeleteOrder(id);
            OrderRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            OrderRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
