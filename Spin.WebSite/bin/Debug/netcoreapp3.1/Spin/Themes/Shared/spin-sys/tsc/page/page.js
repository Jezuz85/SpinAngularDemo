define(["require", "exports", "./base/basePage.js", "./header.js", "./Footer.js"], function (require, exports, basePage_js_1, header_js_1, Footer_js_1) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PageController = void 0;
    class PageController extends basePage_js_1.BasePageController {
        /* #region  Controller */
        constructor(header = null, footer = null) {
            super();
            this.header = header !== null && header !== void 0 ? header : new header_js_1.Header();
            this.footer = footer !== null && footer !== void 0 ? footer : new Footer_js_1.Footer();
        }
        get header() {
            return this._header;
        }
        set header(v) {
            this._header = v;
        }
        get footer() {
            return this._footer;
        }
        set footer(v) {
            this._footer = v;
        }
    }
    exports.PageController = PageController;
});
