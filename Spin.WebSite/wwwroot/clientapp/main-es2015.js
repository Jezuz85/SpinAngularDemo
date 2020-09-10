(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ 0:
/*!*************************************!*\
  !*** multi ./ClientApp/src/main.ts ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Workspace\Website\SpinAngularDemo\Spin.WebSite\ClientApp\src\main.ts */"Ses/");


/***/ }),

/***/ "G612":
/*!***************************************************!*\
  !*** ./ClientApp/src/environments/environment.ts ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var __WEBPACK_AMD_DEFINE_ARRAY__, __WEBPACK_AMD_DEFINE_RESULT__;// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
!(__WEBPACK_AMD_DEFINE_ARRAY__ = [__webpack_require__, exports], __WEBPACK_AMD_DEFINE_RESULT__ = (function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.environment = void 0;
    exports.environment = {
        production: false
    };
}).apply(exports, __WEBPACK_AMD_DEFINE_ARRAY__),
				__WEBPACK_AMD_DEFINE_RESULT__ !== undefined && (module.exports = __WEBPACK_AMD_DEFINE_RESULT__));
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "Ses/":
/*!*******************************!*\
  !*** ./ClientApp/src/main.ts ***!
  \*******************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var __WEBPACK_AMD_DEFINE_ARRAY__, __WEBPACK_AMD_DEFINE_RESULT__;!(__WEBPACK_AMD_DEFINE_ARRAY__ = [__webpack_require__, exports, __webpack_require__(/*! @angular/core */ "fXoL"), __webpack_require__(/*! ./environments/environment */ "G612"), __webpack_require__(/*! ./app/app.module */ "hKqt"), __webpack_require__(/*! @angular/platform-browser */ "jhN1")], __WEBPACK_AMD_DEFINE_RESULT__ = (function (require, exports, core_1, environment_1, __NgCli_bootstrap_1, __NgCli_bootstrap_2) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    if (environment_1.environment.production) {
        core_1.enableProdMode();
    }
    __NgCli_bootstrap_2.platformBrowser().bootstrapModule(__NgCli_bootstrap_1.AppModule)
        .catch(err => console.error(err));
}).apply(exports, __WEBPACK_AMD_DEFINE_ARRAY__),
				__WEBPACK_AMD_DEFINE_RESULT__ !== undefined && (module.exports = __WEBPACK_AMD_DEFINE_RESULT__));


/***/ }),

/***/ "Ywzg":
/*!*************************************************!*\
  !*** ./ClientApp/src/app/app-routing.module.ts ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var __WEBPACK_AMD_DEFINE_ARRAY__, __WEBPACK_AMD_DEFINE_RESULT__;!(__WEBPACK_AMD_DEFINE_ARRAY__ = [__webpack_require__, exports, __webpack_require__(/*! @angular/core */ "fXoL"), __webpack_require__(/*! @angular/router */ "tyNb"), __webpack_require__(/*! @angular/common */ "ofXK"), __webpack_require__(/*! @angular/core */ "fXoL"), __webpack_require__(/*! @angular/router */ "tyNb")], __WEBPACK_AMD_DEFINE_RESULT__ = (function (require, exports, core_1, router_1, common_1, i0, i1) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AppRoutingModule = void 0;
    const routes = [];
    class AppRoutingModule {
    }
    exports.AppRoutingModule = AppRoutingModule;
    AppRoutingModule.ɵmod = i0.ɵɵdefineNgModule({ type: AppRoutingModule });
    AppRoutingModule.ɵinj = i0.ɵɵdefineInjector({ factory: function AppRoutingModule_Factory(t) { return new (t || AppRoutingModule)(); }, imports: [[router_1.RouterModule.forRoot(routes), common_1.CommonModule], router_1.RouterModule] });
    (function () { (typeof ngJitMode === "undefined" || ngJitMode) && i0.ɵɵsetNgModuleScope(AppRoutingModule, { imports: [i1.RouterModule, common_1.CommonModule], exports: [router_1.RouterModule] }); })();
    /*@__PURE__*/ (function () { i0.ɵsetClassMetadata(AppRoutingModule, [{
            type: core_1.NgModule,
            args: [{
                    declarations: [],
                    imports: [router_1.RouterModule.forRoot(routes), common_1.CommonModule],
                    exports: [router_1.RouterModule]
                }]
        }], null, null); })();
}).apply(exports, __WEBPACK_AMD_DEFINE_ARRAY__),
				__WEBPACK_AMD_DEFINE_RESULT__ !== undefined && (module.exports = __WEBPACK_AMD_DEFINE_RESULT__));


/***/ }),

/***/ "hKqt":
/*!*****************************************!*\
  !*** ./ClientApp/src/app/app.module.ts ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var __WEBPACK_AMD_DEFINE_ARRAY__, __WEBPACK_AMD_DEFINE_RESULT__;!(__WEBPACK_AMD_DEFINE_ARRAY__ = [__webpack_require__, exports, __webpack_require__(/*! @angular/platform-browser */ "jhN1"), __webpack_require__(/*! @angular/core */ "fXoL"), __webpack_require__(/*! ./app.component */ "iRwM"), __webpack_require__(/*! ./app-routing.module */ "Ywzg"), __webpack_require__(/*! ./core/services/my-page.service */ "zzdl"), __webpack_require__(/*! @angular/common/http */ "tk/3"), __webpack_require__(/*! @angular/common */ "ofXK"), __webpack_require__(/*! @angular/core */ "fXoL")], __WEBPACK_AMD_DEFINE_RESULT__ = (function (require, exports, platform_browser_1, core_1, app_component_1, app_routing_module_1, my_page_service_1, http_1, common_1, i0) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AppModule = void 0;
    class AppModule {
    }
    exports.AppModule = AppModule;
    AppModule.ɵmod = i0.ɵɵdefineNgModule({ type: AppModule, bootstrap: [app_component_1.AppComponent] });
    AppModule.ɵinj = i0.ɵɵdefineInjector({ factory: function AppModule_Factory(t) { return new (t || AppModule)(); }, providers: [my_page_service_1.MyPageService, { provide: common_1.APP_BASE_HREF, useValue: '/' }], imports: [[
                platform_browser_1.BrowserModule,
                app_routing_module_1.AppRoutingModule,
                http_1.HttpClientModule
            ]] });
    (function () { (typeof ngJitMode === "undefined" || ngJitMode) && i0.ɵɵsetNgModuleScope(AppModule, { declarations: [app_component_1.AppComponent], imports: [platform_browser_1.BrowserModule,
            app_routing_module_1.AppRoutingModule,
            http_1.HttpClientModule] }); })();
    /*@__PURE__*/ (function () { i0.ɵsetClassMetadata(AppModule, [{
            type: core_1.NgModule,
            args: [{
                    declarations: [
                        app_component_1.AppComponent
                    ],
                    imports: [
                        platform_browser_1.BrowserModule,
                        app_routing_module_1.AppRoutingModule,
                        http_1.HttpClientModule
                    ],
                    providers: [my_page_service_1.MyPageService, { provide: common_1.APP_BASE_HREF, useValue: '/' }],
                    bootstrap: [app_component_1.AppComponent]
                }]
        }], null, null); })();
}).apply(exports, __WEBPACK_AMD_DEFINE_ARRAY__),
				__WEBPACK_AMD_DEFINE_RESULT__ !== undefined && (module.exports = __WEBPACK_AMD_DEFINE_RESULT__));


/***/ }),

/***/ "iRwM":
/*!********************************************!*\
  !*** ./ClientApp/src/app/app.component.ts ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var __WEBPACK_AMD_DEFINE_ARRAY__, __WEBPACK_AMD_DEFINE_RESULT__;!(__WEBPACK_AMD_DEFINE_ARRAY__ = [__webpack_require__, exports, __webpack_require__(/*! @angular/core */ "fXoL"), __webpack_require__(/*! @angular/core */ "fXoL"), __webpack_require__(/*! ./core/services/my-page.service */ "zzdl"), __webpack_require__(/*! @angular/common */ "ofXK")], __WEBPACK_AMD_DEFINE_RESULT__ = (function (require, exports, core_1, i0, i1, i2) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AppComponent = void 0;
    function AppComponent_div_1_Template(rf, ctx) { if (rf & 1) {
        i0.ɵɵelementStart(0, "div");
        i0.ɵɵelement(1, "div", 1);
        i0.ɵɵelementEnd();
    } if (rf & 2) {
        const item_r1 = ctx.$implicit;
        i0.ɵɵadvance(1);
        i0.ɵɵproperty("innerHTML", item_r1.cuerpo, i0.ɵɵsanitizeHtml);
    } }
    class AppComponent {
        constructor(apiService) {
            this.apiService = apiService;
        }
        ngOnInit() {
            this.retrieveHtmlBody();
        }
        retrieveHtmlBody() {
            this.apiService.getAll()
                .subscribe(data => {
                this.TemplateHtml = data;
            }, error => {
            });
        }
    }
    exports.AppComponent = AppComponent;
    AppComponent.ɵfac = function AppComponent_Factory(t) { return new (t || AppComponent)(i0.ɵɵdirectiveInject(i1.MyPageService)); };
    AppComponent.ɵcmp = i0.ɵɵdefineComponent({ type: AppComponent, selectors: [["my-template"]], decls: 2, vars: 1, consts: [[4, "ngFor", "ngForOf"], [3, "innerHTML"]], template: function AppComponent_Template(rf, ctx) { if (rf & 1) {
            i0.ɵɵtext(0, "Hola\n");
            i0.ɵɵtemplate(1, AppComponent_div_1_Template, 2, 1, "div", 0);
        } if (rf & 2) {
            i0.ɵɵadvance(1);
            i0.ɵɵproperty("ngForOf", ctx.TemplateHtml);
        } }, directives: [i2.NgForOf], encapsulation: 2 });
    /*@__PURE__*/ (function () { i0.ɵsetClassMetadata(AppComponent, [{
            type: core_1.Component,
            args: [{
                    selector: 'my-template',
                    templateUrl: './app.component.html',
                    styles: []
                }]
        }], function () { return [{ type: i1.MyPageService }]; }, null); })();
}).apply(exports, __WEBPACK_AMD_DEFINE_ARRAY__),
				__WEBPACK_AMD_DEFINE_RESULT__ !== undefined && (module.exports = __WEBPACK_AMD_DEFINE_RESULT__));


/***/ }),

/***/ "zn8P":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "zn8P";

/***/ }),

/***/ "zzdl":
/*!************************************************************!*\
  !*** ./ClientApp/src/app/core/services/my-page.service.ts ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var __WEBPACK_AMD_DEFINE_ARRAY__, __WEBPACK_AMD_DEFINE_RESULT__;!(__WEBPACK_AMD_DEFINE_ARRAY__ = [__webpack_require__, exports, __webpack_require__(/*! @angular/core */ "fXoL"), __webpack_require__(/*! @angular/core */ "fXoL"), __webpack_require__(/*! @angular/common/http */ "tk/3")], __WEBPACK_AMD_DEFINE_RESULT__ = (function (require, exports, core_1, i0, i1) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MyPageService = void 0;
    class MyPageService {
        constructor(http) {
            this.http = http;
        }
        getAll() {
            return this.http.get('/Api/Home/DemoApi/Get');
        }
    }
    exports.MyPageService = MyPageService;
    MyPageService.ɵfac = function MyPageService_Factory(t) { return new (t || MyPageService)(i0.ɵɵinject(i1.HttpClient)); };
    MyPageService.ɵprov = i0.ɵɵdefineInjectable({ token: MyPageService, factory: MyPageService.ɵfac, providedIn: 'root' });
    /*@__PURE__*/ (function () { i0.ɵsetClassMetadata(MyPageService, [{
            type: core_1.Injectable,
            args: [{
                    providedIn: 'root'
                }]
        }], function () { return [{ type: i1.HttpClient }]; }, null); })();
}).apply(exports, __WEBPACK_AMD_DEFINE_ARRAY__),
				__WEBPACK_AMD_DEFINE_RESULT__ !== undefined && (module.exports = __WEBPACK_AMD_DEFINE_RESULT__));


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main-es2015.js.map