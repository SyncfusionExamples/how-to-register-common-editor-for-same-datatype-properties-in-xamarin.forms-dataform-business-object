using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RegisterCommonEditor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataForm.RegisterEditor("Slider", new CustomSliderEditor(dataForm));
            dataForm.RegisterEditor(typeof(int), "Slider");
        }
    }
    public class CustomSliderEditor : DataFormEditor<Slider>
    {
        public CustomSliderEditor(SfDataForm dataForm) : base(dataForm)
        {

        }

        protected override Slider OnCreateEditorView(DataFormItem dataFormItem)
        {
            return new Slider
            {
                Minimum = 0,
                Maximum = 23,
                MaximumTrackColor = Color.Gray,
                MinimumTrackColor = Color.HotPink,
                ThumbColor = Color.HotPink
            };
        }

        protected override void OnInitializeView(DataFormItem dataFormItem, Slider view)
        {
            base.OnInitializeView(dataFormItem, view);

        }
    }
}
