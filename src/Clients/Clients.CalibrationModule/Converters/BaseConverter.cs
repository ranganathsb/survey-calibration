﻿using System;
using System.Windows.Markup;

namespace Clients.CalibrationModule.Converters {
    public abstract class BaseConverter : MarkupExtension {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
