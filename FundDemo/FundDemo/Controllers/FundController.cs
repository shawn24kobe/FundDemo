using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundDemo.Entities;
using FundDemo.Services.IRepository;
using FundDemo.Dtos;

namespace FundDemo.Controllers
{
    public class FundController : Controller
    {
        private readonly IFundRepository fundRepository;

        public FundController(IFundRepository _fundRepository)
        {
            fundRepository = _fundRepository;
        }

        // GET: FundController
        public async Task<ActionResult> Index()
        {
            List<FundWeightDto> fundWeights = await fundRepository.GetFundWeight();
            return View(fundWeights);
        }

        public async Task<ActionResult> FundData()
        {
            List<FundData> fundDatas = await fundRepository.GetFund();
            return View(fundDatas);
        }

        // GET: FundController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FundController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FundController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FundController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FundController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FundController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FundController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
