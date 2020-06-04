using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Shared;
using System.Windows.Media;
using MaskFormat = Syncfusion.Windows.Controls.Input.MaskFormat;

namespace InputOptions
{
    class ViewModel : NotificationObject
    {
        private bool showPromptOnFocus = true;
        private MaskFormat valueMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        private object _value;
        private InputValidationMode validationMode = InputValidationMode.KeyPress;
        private Brush errorBorderBrush = Brushes.Yellow;
        private string mask= @"\+1 \([0-9]\d{2}\) [0-9]\d{2}-[0-9]\d{3}";

        public bool ShowPromptOnFocus
        {
            get
            {
                return showPromptOnFocus;
            }
            set
            {
                showPromptOnFocus = value;
                this.RaisePropertyChanged(nameof(ShowPromptOnFocus));
            }
        }

        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                this.RaisePropertyChanged(nameof(Value));
            }
        }

        public MaskFormat ValueMaskFormat
        {
            get
            {
                return valueMaskFormat;
            }
            set
            {
                valueMaskFormat = value;
                this.RaisePropertyChanged(nameof(ValueMaskFormat));
            }
        }

        public InputValidationMode ValidationMode
        {
            get
            {
                return validationMode;
            }
            set
            {
                validationMode = value;
                this.RaisePropertyChanged(nameof(ValidationMode));
            }
        }

        public Brush ErrorBorderBrush
        {
            get
            {
                return errorBorderBrush;
            }
            set
            {
                errorBorderBrush = value;
                this.RaisePropertyChanged(nameof(ErrorBorderBrush));
            }
        }

        public string Mask
        {
            get
            {
                return mask;
            }
            set
            {
                mask = value;
                this.RaisePropertyChanged(nameof(Mask));
            }
        }
    }
}
