define(["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.contact = exports.BaseHeader = void 0;
    class BaseHeader {
        /**
         * constructor
         */
        constructor() {
        }
        get contact() {
            return this._contact;
        }
        set contact(v) {
            this._contact = v;
        }
    }
    exports.BaseHeader = BaseHeader;
    class contact {
        show() {
        }
    }
    exports.contact = contact;
});
