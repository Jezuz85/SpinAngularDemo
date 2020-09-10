define(["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.BaseComponent = void 0;
    class BaseComponent {
        /* #region  Constructor */
        constructor(e) {
            this.control = e;
        }
        get control() {
            return this._control;
        }
        set control(v) {
            this._control = v;
        }
    }
    exports.BaseComponent = BaseComponent;
});
