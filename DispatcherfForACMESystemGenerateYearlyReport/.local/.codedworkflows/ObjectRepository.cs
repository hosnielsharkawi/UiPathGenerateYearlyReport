using UiPath.CodedWorkflows.DescriptorIntegration;

namespace DispatcherfForACMESystemGenerateYearlyReport.ObjectRepository
{
    public static class Descriptors
    {
        public static class Edge_ACME_System_1
        {
            static string _reference = "ZWx_c_eSkU-ngsBnYhkSCw/4xQ_SpeTxEKX60abOL5ikw";
            public static _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1____Open Edge_ACME_System_1____Open { get; private set; } = new _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1____Open();
            public static _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1___Log_In_page Edge_ACME_System_1___Log_In_page { get; private set; } = new _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1___Log_In_page();
            public static _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1___Work_Items Edge_ACME_System_1___Work_Items { get; private set; } = new _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1___Work_Items();
            public static _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1___Work_Items_1_ Edge_ACME_System_1___Work_Items_1_ { get; private set; } = new _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1___Work_Items_1_();
            public static _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1___WorkItem Edge_ACME_System_1___WorkItem { get; private set; } = new _Implementation._Edge_ACME_System_1.__Edge_ACME_System_1___WorkItem();
        }
    }
}

namespace DispatcherfForACMESystemGenerateYearlyReport._Implementation
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

    namespace _Edge_ACME_System_1._Edge_ACME_System_1____Open
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
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/8UwmCt0gSUiWuMioGr-2fA",
                    DisplayName = "Log Out",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Edge_ACME_System_1._Edge_ACME_System_1____Open
    {
        public class __Log_Out_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Log_Out_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/7O1NIr3MPUqr_aeB9mthVQ",
                    DisplayName = "Log Out(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Edge_ACME_System_1
    {
        public class __Edge_ACME_System_1____Open : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1____Open()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/YIXrXVPLTUytibOeab1BbQ",
                    DisplayName = "Edge ACME System 1 -  Open",
                    Screen = this
                };
                Log_Out = new _Implementation._Edge_ACME_System_1._Edge_ACME_System_1____Open.__Log_Out(this, null);
                Log_Out_1_ = new _Implementation._Edge_ACME_System_1._Edge_ACME_System_1____Open.__Log_Out_1_(this, null);
            }

            public _Implementation._Edge_ACME_System_1._Edge_ACME_System_1____Open.__Log_Out Log_Out { get; private set; }
            public _Implementation._Edge_ACME_System_1._Edge_ACME_System_1____Open.__Log_Out_1_ Log_Out_1_ { get; private set; }
        }
    }

    namespace _Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page
    {
        public class __Email : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/9WWtzOBeKk-4eeXYWSPcRQ",
                    DisplayName = "Email",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page
    {
        public class __Login : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Login(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/kZUS7-xtbES_cF6f9J_NTQ",
                    DisplayName = "Login",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page
    {
        public class __Password : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Password(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/7YCtKDKb-067KOLooduImg",
                    DisplayName = "Password",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Edge_ACME_System_1
    {
        public class __Edge_ACME_System_1___Log_In_page : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1___Log_In_page()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/Yf1wApeKL0mN4hFPi5-uMA",
                    DisplayName = "Edge ACME System 1 - Log In page",
                    Screen = this
                };
                Email = new _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page.__Email(this, null);
                Login = new _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page.__Login(this, null);
                Password = new _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page.__Password(this, null);
            }

            public _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page.__Email Email { get; private set; }
            public _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page.__Login Login { get; private set; }
            public _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Log_In_page.__Password Password { get; private set; }
        }
    }

    namespace _Edge_ACME_System_1._Edge_ACME_System_1___Work_Items
    {
        public class __TaxID_DE456232_Name_P_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __TaxID_DE456232_Name_P_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/qtNjA_WIJEC6V3E13d7PNg",
                    DisplayName = "TaxID DE456232 Name P…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Edge_ACME_System_1
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
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/3OInasxTfkWJZONe7IOrjQ",
                    DisplayName = "Edge ACME System 1 - Work Items",
                    Screen = this
                };
                TaxID_DE456232_Name_P_ = new _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Work_Items.__TaxID_DE456232_Name_P_(this, null);
            }

            public _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Work_Items.__TaxID_DE456232_Name_P_ TaxID_DE456232_Name_P_ { get; private set; }
        }
    }

    namespace _Edge_ACME_System_1._Edge_ACME_System_1___Work_Items_1_
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
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/cG648vjMn0uvDI52sHZXSg",
                    DisplayName = "Log Out",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Edge_ACME_System_1
    {
        public class __Edge_ACME_System_1___Work_Items_1_ : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1___Work_Items_1_()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/feBwKG0vjEqwBTIXt1800A",
                    DisplayName = "Edge ACME System 1 - Work Items(1)",
                    Screen = this
                };
                Log_Out = new _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Work_Items_1_.__Log_Out(this, null);
            }

            public _Implementation._Edge_ACME_System_1._Edge_ACME_System_1___Work_Items_1_.__Log_Out Log_Out { get; private set; }
        }
    }

    namespace _Edge_ACME_System_1
    {
        public class __Edge_ACME_System_1___WorkItem : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Edge_ACME_System_1___WorkItem()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "ZWx_c_eSkU-ngsBnYhkSCw/Zm5BPNgOXkmCuf1rhPvi1A",
                    DisplayName = "Edge ACME System 1 - WorkItem",
                    Screen = this
                };
            }
        }
    }
}