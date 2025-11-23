using UiPath.CodedWorkflows.DescriptorIntegration;

namespace PerformerfForACMESystemGenerateYearlyReport.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Edge_ACME_System_1___Download_Monthly_Report
        {
            static string _reference = "HwkijUt3IkKlwyshYzTYCA/BS8hmApHL0Wzc1Takp91ew";
            public static _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1 Edge_ACME_System_1 { get; private set; } = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1();
            public static _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1___Dashboard Edge_ACME_System_1___Dashboard { get; private set; } = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1___Dashboard();
            public static _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1___Download_Monthly_Report Edge_ACME_System_1___Download_Monthly_Report { get; private set; } = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1___Download_Monthly_Report();
            public static _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1___Upload_Yearly_Report Edge_ACME_System_1___Upload_Yearly_Report { get; private set; } = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1___Upload_Yearly_Report();
            public static _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1___Work_Items Edge_ACME_System_1___Work_Items { get; private set; } = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__Edge_ACME_System_1___Work_Items();
            public static _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__New_application New_application { get; private set; } = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report.__New_application();
        }

        public static class __Edge_ACME_System_1___Login_Page
        {
            static string _reference = "HwkijUt3IkKlwyshYzTYCA/BoKWoBY72k6VIuzd2TSrYg";
            public static _Implementation.___Edge_ACME_System_1___Login_Page.__Edge_ACME_System_1___Login_Page Edge_ACME_System_1___Login_Page { get; private set; } = new _Implementation.___Edge_ACME_System_1___Login_Page.__Edge_ACME_System_1___Login_Page();
        }
    }
}

namespace PerformerfForACMESystemGenerateYearlyReport._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1
    {
        public class _____ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public _____(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/7Gmsfq_COEqG_Lis6K26lg",
                    DisplayName = "---",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1
    {
        public class __Add_Comments : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Add_Comments(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/Kdau_jvTKEeD3ZB41H5oMg",
                    DisplayName = "Add Comments",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1
    {
        public class __Update_Work_Item : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Update_Work_Item(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/ygzkmP6gf0etYYWC0kwIRg",
                    DisplayName = "Update Work Item",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __Edge_ACME_System_1 : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/4XGRck8SoEuIboVPSZp6lg",
                    DisplayName = "Edge ACME System 1",
                    Screen = this
                };
                ___ = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1._____(this, null);
                Add_Comments = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1.__Add_Comments(this, null);
                Update_Work_Item = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1.__Update_Work_Item(this, null);
            }

            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1._____ ___ { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1.__Add_Comments Add_Comments { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1.__Update_Work_Item Update_Work_Item { get; private set; }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Dashboard
    {
        public class __Log_Out : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Log_Out(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/VX69y8CwWkq90qLveozRvg",
                    DisplayName = "Log Out",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Dashboard
    {
        public class __Reports___Download_Mont_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Reports___Download_Mont_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/i2lCUncZQ0aSZFa5y9x40g",
                    DisplayName = "Reports - Download Mont…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __Edge_ACME_System_1___Dashboard : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1___Dashboard()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/uDpzO2ZzAE-w8gm0JzTH4w",
                    DisplayName = "Edge ACME System 1 - Dashboard",
                    Screen = this
                };
                Log_Out = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Dashboard.__Log_Out(this, null);
                Reports___Download_Mont_ = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Dashboard.__Reports___Download_Mont_(this, null);
            }

            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Dashboard.__Log_Out Log_Out { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Dashboard.__Reports___Download_Mont_ Reports___Download_Mont_ { get; private set; }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report
    {
        public class _____ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public _____(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/hchmEF-fuk6svcoOph8r9g",
                    DisplayName = "---",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report
    {
        public class ______1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ______1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/dscueQRLo06yKZ70vEFQ7A",
                    DisplayName = "---(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report
    {
        public class ______2_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ______2_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/LbSEtp9yEE2wcfwPjqg4uA",
                    DisplayName = "---(2)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __acme_test_uipath_com_sa_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __acme_test_uipath_com_sa_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/5UsT1k3qk06LfnfGF0Y1gg",
                    DisplayName = "acme-test.uipath.com sa…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __Download_Report : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Download_Report(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/r3QcfR96okC8Ue3LZMNlWA",
                    DisplayName = "Download Report",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __OK : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __OK(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/TskwPe_3hEe_tMGme6MHhw",
                    DisplayName = "OK",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __Vendor_TaxID : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Vendor_TaxID(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/53UUaCvV5EGFzq0kYbh1kg",
                    DisplayName = "Vendor TaxID",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __Edge_ACME_System_1___Download_Monthly_Report : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1___Download_Monthly_Report()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/akIsy0Y9E06sjAra6fRs0A",
                    DisplayName = "Edge ACME System 1 - Download Monthly Report",
                    Screen = this
                };
                ___ = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report._____(this, null);
                ____1_ = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.______1_(this, null);
                ____2_ = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.______2_(this, null);
                acme_test_uipath_com_sa_ = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.__acme_test_uipath_com_sa_(this, null);
                Download_Report = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.__Download_Report(this, null);
                OK = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.__OK(this, null);
                Vendor_TaxID = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.__Vendor_TaxID(this, null);
            }

            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report._____ ___ { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.______1_ ____1_ { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.______2_ ____2_ { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.__acme_test_uipath_com_sa_ acme_test_uipath_com_sa_ { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.__Download_Report Download_Report { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.__OK OK { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Download_Monthly_Report.__Vendor_TaxID Vendor_TaxID { get; private set; }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report
    {
        public class _____ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public _____(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/mHd9UV-5ZUC_QtIF43eAjw",
                    DisplayName = "---",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report
    {
        public class ___Open : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Open(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/aQeR8T4CQkqFELWufTeCPA",
                    DisplayName = "&Open",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report
    {
        public class __File__name : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __File__name(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/K0K5pAbDAU2awL2FQCj9yA",
                    DisplayName = "File &name",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report
    {
        public class __Report_was_uploaded___c_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Report_was_uploaded___c_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/u71pjCB9QkSMWlccDrT-4Q",
                    DisplayName = "Report was uploaded - c…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report
    {
        public class __Select_Report_File : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Select_Report_File(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/pWgxoyFGek6_IHGfbtdVQQ",
                    DisplayName = "Select Report File",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report
    {
        public class __Upload_Report : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Upload_Report(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/-j3Nvq3dG0CAj_eovKnKjw",
                    DisplayName = "Upload Report",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report
    {
        public class __Vendor_TaxID : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Vendor_TaxID(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/n4XRlm0tsEKv1S1aeJ2Hhw",
                    DisplayName = "Vendor TaxID",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __Edge_ACME_System_1___Upload_Yearly_Report : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1___Upload_Yearly_Report()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/TgOcXiiR3EylgBHS7gQKaQ",
                    DisplayName = "Edge ACME System 1 - Upload Yearly Report",
                    Screen = this
                };
                ___ = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report._____(this, null);
                _Open = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.___Open(this, null);
                File__name = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__File__name(this, null);
                Report_was_uploaded___c_ = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__Report_was_uploaded___c_(this, null);
                Select_Report_File = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__Select_Report_File(this, null);
                Upload_Report = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__Upload_Report(this, null);
                Vendor_TaxID = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__Vendor_TaxID(this, null);
            }

            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report._____ ___ { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.___Open _Open { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__File__name File__name { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__Report_was_uploaded___c_ Report_was_uploaded___c_ { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__Select_Report_File Select_Report_File { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__Upload_Report Upload_Report { get; private set; }
            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Upload_Yearly_Report.__Vendor_TaxID Vendor_TaxID { get; private set; }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Work_Items
    {
        public class __Update_Work_Item : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Update_Work_Item(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/u4TegVffdES0zyI4Xp1xnw",
                    DisplayName = "Update Work Item",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __Edge_ACME_System_1___Work_Items : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1___Work_Items()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/F2qGjwdy0EaQqaVArroaVw",
                    DisplayName = "Edge ACME System 1 - Work Items",
                    Screen = this
                };
                Update_Work_Item = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Work_Items.__Update_Work_Item(this, null);
            }

            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._Edge_ACME_System_1___Work_Items.__Update_Work_Item Update_Work_Item { get; private set; }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report._New_application
    {
        public class __ACME_System_1 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ACME_System_1(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/ZRXXidXTx0OojykhoiY_sg",
                    DisplayName = "ACME System 1",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Download_Monthly_Report
    {
        public class __New_application : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __New_application()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/tlgJ2RndmkasEw_UntO9eA",
                    DisplayName = "New application",
                    Screen = this
                };
                ACME_System_1 = new _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._New_application.__ACME_System_1(this, null);
            }

            public _Implementation.___Edge_ACME_System_1___Download_Monthly_Report._New_application.__ACME_System_1 ACME_System_1 { get; private set; }
        }
    }

    namespace ___Edge_ACME_System_1___Login_Page._Edge_ACME_System_1___Login_Page
    {
        public class __These_credentials_do_no_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __These_credentials_do_no_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/7rz_SEsrIk2_c44g6UVCqw",
                    DisplayName = "These credentials do no…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Edge_ACME_System_1___Login_Page
    {
        public class __Edge_ACME_System_1___Login_Page : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1___Login_Page()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "HwkijUt3IkKlwyshYzTYCA/k_SRnsFSokSynPER50rlJA",
                    DisplayName = "Edge ACME System 1 - Login Page",
                    Screen = this
                };
                These_credentials_do_no_ = new _Implementation.___Edge_ACME_System_1___Login_Page._Edge_ACME_System_1___Login_Page.__These_credentials_do_no_(this, null);
            }

            public _Implementation.___Edge_ACME_System_1___Login_Page._Edge_ACME_System_1___Login_Page.__These_credentials_do_no_ These_credentials_do_no_ { get; private set; }
        }
    }
}