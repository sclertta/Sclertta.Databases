using System;
using System.Collections.Generic;
using System.Text;

namespace Sclertta.Databases.Personnel.Enums
{
    public class ObjectTypeEnum
    {
        private ObjectTypeEnum(string type)
        {
            Code = type;
        }

        public string Code { get; }

        public static ObjectTypeEnum ALLOWANCE = new ObjectTypeEnum("ALLOWANCE");
        public static ObjectTypeEnum BusinessOLAP = new ObjectTypeEnum("BusinessOLAP");
        public static ObjectTypeEnum COLUMN = new ObjectTypeEnum("COLUMN");
        public static ObjectTypeEnum FUNCTION = new ObjectTypeEnum("FUNCTION");
        public static ObjectTypeEnum GROUP = new ObjectTypeEnum("GROUP");
        public static ObjectTypeEnum MESSAGE = new ObjectTypeEnum("MESSAGE");
        public static ObjectTypeEnum PAYMENT = new ObjectTypeEnum("PAYMENT");
        public static ObjectTypeEnum PROCEDURE = new ObjectTypeEnum("PROCEDURE");
        public static ObjectTypeEnum REPORT = new ObjectTypeEnum("REPORT");
        public static ObjectTypeEnum REPORTITEM = new ObjectTypeEnum("REPORTITEM");
        public static ObjectTypeEnum ReportNew = new ObjectTypeEnum("ReportNew");
        public static ObjectTypeEnum REPORTTABLE = new ObjectTypeEnum("REPORTTABLE");
        public static ObjectTypeEnum STRING = new ObjectTypeEnum("STRING");
        public static ObjectTypeEnum TABLE = new ObjectTypeEnum("TABLE");
        public static ObjectTypeEnum TACTACTION = new ObjectTypeEnum("TACTACTION");
        public static ObjectTypeEnum TACTCATEGORY = new ObjectTypeEnum("TACTCATEGORY");
        public static ObjectTypeEnum TActionList = new ObjectTypeEnum("TActionList");
        public static ObjectTypeEnum TADDRESS_LABEL = new ObjectTypeEnum("TADDRESS_LABEL");
        public static ObjectTypeEnum TAPPLICATION = new ObjectTypeEnum("TAPPLICATION");
        public static ObjectTypeEnum TAPPLICATIONDLL = new ObjectTypeEnum("TAPPLICATIONDLL");
        public static ObjectTypeEnum TBevel = new ObjectTypeEnum("TBevel");
        public static ObjectTypeEnum TBUTTON = new ObjectTypeEnum("TBUTTON");
        public static ObjectTypeEnum TBUTTON_BIT = new ObjectTypeEnum("TBUTTON(BIT)");
        public static ObjectTypeEnum TBUTTON_SPEED = new ObjectTypeEnum("TBUTTON(SPEED)");
        public static ObjectTypeEnum TCHECKBOX = new ObjectTypeEnum("TCHECKBOX");
        public static ObjectTypeEnum TColorBox = new ObjectTypeEnum("TColorBox");
        public static ObjectTypeEnum TCOLUMN = new ObjectTypeEnum("TCOLUMN");
        public static ObjectTypeEnum TCOMBOBOX = new ObjectTypeEnum("TCOMBOBOX");
        public static ObjectTypeEnum TCoolBar = new ObjectTypeEnum("TCoolBar");
        public static ObjectTypeEnum TcxSpinButton = new ObjectTypeEnum("TcxSpinButton");
        public static ObjectTypeEnum TDATAMODULE = new ObjectTypeEnum("TDATAMODULE");
        public static ObjectTypeEnum TDateTimePicker = new ObjectTypeEnum("TDateTimePicker");
        public static ObjectTypeEnum TDBCHECKBOX = new ObjectTypeEnum("TDBCHECKBOX");
        public static ObjectTypeEnum TDBComboBox = new ObjectTypeEnum("TDBComboBox");
        public static ObjectTypeEnum TDBEDIT = new ObjectTypeEnum("TDBEDIT");
        public static ObjectTypeEnum TDBGRID = new ObjectTypeEnum("TDBGRID");
        public static ObjectTypeEnum TDBLOOKUPCOMBOBOX = new ObjectTypeEnum("TDBLOOKUPCOMBOBOX");
        public static ObjectTypeEnum TDBMemo = new ObjectTypeEnum("TDBMemo");
        public static ObjectTypeEnum TDBNavigator = new ObjectTypeEnum("TDBNavigator");
        public static ObjectTypeEnum TDBRADIOGROUP = new ObjectTypeEnum("TDBRADIOGROUP");
        public static ObjectTypeEnum TDBRichEdit = new ObjectTypeEnum("TDBRichEdit");
        public static ObjectTypeEnum TDBText = new ObjectTypeEnum("TDBText");
        public static ObjectTypeEnum TDOCUMENT_USER = new ObjectTypeEnum("TDOCUMENT_USER");
        public static ObjectTypeEnum TEDIT = new ObjectTypeEnum("TEDIT");
        public static ObjectTypeEnum TFIELD = new ObjectTypeEnum("TFIELD");
        public static ObjectTypeEnum TFORM = new ObjectTypeEnum("TFORM");
        public static ObjectTypeEnum TFORMDLL = new ObjectTypeEnum("TFORMDLL");
        public static ObjectTypeEnum TFormShell = new ObjectTypeEnum("TFormShell");
        public static ObjectTypeEnum TFrame = new ObjectTypeEnum("TFrame");
        public static ObjectTypeEnum TGauge = new ObjectTypeEnum("TGauge");
        public static ObjectTypeEnum TGROUPBOX = new ObjectTypeEnum("TGROUPBOX");
        public static ObjectTypeEnum THelp = new ObjectTypeEnum("THelp");
        public static ObjectTypeEnum THELPITEM = new ObjectTypeEnum("THELPITEM");
        public static ObjectTypeEnum TImage = new ObjectTypeEnum("TImage");
        public static ObjectTypeEnum TLABEL = new ObjectTypeEnum("TLABEL");
        public static ObjectTypeEnum TLABEL_USER = new ObjectTypeEnum("TLABEL_USER");
        public static ObjectTypeEnum TListBox = new ObjectTypeEnum("TListBox");
        public static ObjectTypeEnum TListColumn = new ObjectTypeEnum("TListColumn");
        public static ObjectTypeEnum TListView = new ObjectTypeEnum("TListView");
        public static ObjectTypeEnum TMaskEdit = new ObjectTypeEnum("TMaskEdit");
        public static ObjectTypeEnum TMemo = new ObjectTypeEnum("TMemo");
        public static ObjectTypeEnum TNoteBook = new ObjectTypeEnum("TNoteBook");
        public static ObjectTypeEnum TPage = new ObjectTypeEnum("TPage");
        public static ObjectTypeEnum TPAGECONTROL = new ObjectTypeEnum("TPAGECONTROL");
        public static ObjectTypeEnum TPANEL = new ObjectTypeEnum("TPANEL");
        public static ObjectTypeEnum TProgressBar = new ObjectTypeEnum("TProgressBar");
        public static ObjectTypeEnum TQRAngledLabel = new ObjectTypeEnum("TQRAngledLabel");
        public static ObjectTypeEnum TQRBAND = new ObjectTypeEnum("TQRBAND");
        public static ObjectTypeEnum TQRCHILDBAND = new ObjectTypeEnum("TQRCHILDBAND");
        public static ObjectTypeEnum TQRDBJpeg = new ObjectTypeEnum("TQRDBJpeg");
        public static ObjectTypeEnum TQRDBTEXT = new ObjectTypeEnum("TQRDBTEXT");
        public static ObjectTypeEnum TQRExpr = new ObjectTypeEnum("TQRExpr");
        public static ObjectTypeEnum TQRGROUP = new ObjectTypeEnum("TQRGROUP");
        public static ObjectTypeEnum TQRLABEL = new ObjectTypeEnum("TQRLABEL");
        public static ObjectTypeEnum TQRMemo = new ObjectTypeEnum("TQRMemo");
        public static ObjectTypeEnum TQRShape = new ObjectTypeEnum("TQRShape");
        public static ObjectTypeEnum TQRSUBDETAIL = new ObjectTypeEnum("TQRSUBDETAIL");
        public static ObjectTypeEnum TQUERY = new ObjectTypeEnum("TQUERY");
        public static ObjectTypeEnum TQUICKREPORT = new ObjectTypeEnum("TQUICKREPORT");
        public static ObjectTypeEnum TRADIOBUTTON = new ObjectTypeEnum("TRADIOBUTTON");
        public static ObjectTypeEnum TRADIOGROUP = new ObjectTypeEnum("TRADIOGROUP");
        public static ObjectTypeEnum TResource = new ObjectTypeEnum("TResource");
        public static ObjectTypeEnum TRichEdit = new ObjectTypeEnum("TRichEdit");
        public static ObjectTypeEnum TRIGGER = new ObjectTypeEnum("TRIGGER");
        public static ObjectTypeEnum TSCROLLBOX = new ObjectTypeEnum("TSCROLLBOX");
        public static ObjectTypeEnum TSpinEdit = new ObjectTypeEnum("TSpinEdit");
        public static ObjectTypeEnum TTABSHEET = new ObjectTypeEnum("TTABSHEET");
        public static ObjectTypeEnum TToolBar = new ObjectTypeEnum("TToolBar");
        public static ObjectTypeEnum TToolButton = new ObjectTypeEnum("TToolButton");
        public static ObjectTypeEnum TUpDown = new ObjectTypeEnum("TUpDown");
        public static ObjectTypeEnum TValueListEditor = new ObjectTypeEnum("TValueListEditor");
        public static ObjectTypeEnum TWORKSHEET = new ObjectTypeEnum("TWORKSHEET");
        public static ObjectTypeEnum VIEW = new ObjectTypeEnum("VIEW");
        public static ObjectTypeEnum VIRTUAL_ATTRIBUTE = new ObjectTypeEnum("VIRTUAL_ATTRIBUTE");
        public static ObjectTypeEnum VIRTUAL_ENTITY = new ObjectTypeEnum("VIRTUAL_ENTITY");
        public static ObjectTypeEnum VIRTUAL_RELATIONSHIP = new ObjectTypeEnum("VIRTUAL_RELATIONSHIP");
    }
}
