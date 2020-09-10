define(["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.BaseControl = void 0;
    /**
     * Base for create controls
     */
    class BaseControl {
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
    exports.BaseControl = BaseControl;
});
