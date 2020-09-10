using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Spin.Modules.Home.Api.Controllers
{
    public class DemoApiController : SpinControllerApi
    {
        private static readonly string[] TemplatesSpin = new[]
        {
            "<div class='content-site' *ngFor='let item of homeData'>" +
            "<div class='banner' style=' background-image: url('/Spin/Themes/SpinTheme/Module/Home/Resource/img/banner.jpg')'>" +
            "<h1>" +
            "WELCOME TO SPIN FRAMEWORK" +
            "</h1>" +
            "<div class='version-header'>" +
            "0.1.27.4(Release)" +
            "</div>" +
            "</div>" +
            "<div class='content-info-site'>" +
            "<div class='description'>" +
            "\n            Tool free for create websites, it have the  functionalities needed by develop easy  and structured. The main new topic is new form create modules and themes in a short time by powered .NET Core. This a tool multiplamform can used different data base such as Mysql or SQL Server and different operative system such as Centos, Ubuntu and Windows.\n        " +
            "</div>" +
            "</div>" +
            "<div class='let-get-stated'>" +
            "<h2>" +
            "HOW TO START?" +
            "</h2>" +
            "<div class='row justify-content-center'>" +
            "<div class='col-12 col-md-3'>" +
            "<div class='item-let-stared'>" +
            "<a href='http://dev.cmsspin.com/Sample' target='_blank'>" +
            "<i class='fas fa-hat-wizard'></i>" +
            "HOW TO CREATE A SITE" +
            "</a>" +
            "</div>" +
            "</div>" +
            "<div class='col-12 col-md-3'>" +
            "<div class='item-let-stared'>" +
            "<a href='http://dev.cmsspin.com/Sample' target='_blank'>" +
            "<i class='fas fa-box'></i>" +
            "SAMPLES" +
            "</a>" +
            "</div>" +
            "</div>" +
            "<div class='col-12 col-md-3'>" +
            "<div class='item-let-stared'>" +
            "<a href='http://dev.cmsspin.com/Tutorial' target='_blank'>" +
            "<i class='fas fa-video'></i>" +
            "TUTORIALS" +
            "</a>" +
            "</div></div></div></div></div>"
        };

        [HttpGet]
        public IEnumerable<SpinHtml> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new SpinHtml
            {
                Cuerpo = TemplatesSpin[rng.Next(TemplatesSpin.Length)]
            })
            .ToArray();
        }
    }
    public class SpinHtml
    {
        public string Cuerpo { get; set; }
    }
}
