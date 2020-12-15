
#pragma warning disable 162

namespace POC.BizTalk.AlwaysEncrypted
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "EmployeeOperation",
        new System.Type[]{
            typeof(POC.BizTalk.AlwaysEncrypted.__messagetype_POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ReceiveEmployeePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceiveEmployeePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceiveEmployeePortType(ReceiveEmployeePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceiveEmployeePortType p = new ReceiveEmployeePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo EmployeeOperation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "EmployeeOperation",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceiveEmployeePortType),
            typeof(__messagetype_POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "EmployeeOperation" ] = EmployeeOperation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Insert",
        new System.Type[]{
            typeof(POC.BizTalk.AlwaysEncrypted.__messagetype_POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLEmployeeInsertPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLEmployeeInsertPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLEmployeeInsertPortType(SQLEmployeeInsertPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLEmployeeInsertPortType p = new SQLEmployeeInsertPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Insert = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Insert",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SQLEmployeeInsertPortType),
            typeof(__messagetype_POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Insert" ] = Insert;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 137 "C:\DEV\POC\POC.BizTalk.AlwaysEncrypted\POC.BizTalk.AlwaysEncrypted\POCInsertIntoSQL.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveEmployeePort", "EmployeeOperation", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC.BizTalk.AlwaysEncrypted.ReceiveEmployeePortType),
            typeof(POC.BizTalk.AlwaysEncrypted.SQLEmployeeInsertPortType)
        },
        new System.String[] {
            "ReceiveEmployeePort",
            "SQLEmployeeInsertPort"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class POCInsertIntoSQL : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(POCInsertIntoSQL));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static POCInsertIntoSQL()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __POCInsertIntoSQL_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public POCInsertIntoSQL(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "POCInsertIntoSQL", tracker)
        {
            ConstructorHelper();
        }

        public POCInsertIntoSQL(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "POCInsertIntoSQL")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>63c12843-b8c3-4361-9372-5c894eaa9e86</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e0892531-072d-472f-99d3-12e6bf7ddb9c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive XML</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>298b9d1b-5c25-42eb-bdb3-300fe66d208c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send XML</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'POCInsertIntoSQL'</ActionName><IsAtomic>0</IsAtomic><Line>137</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>147</Line><Position>22</Position><ShapeID>'e0892531-072d-472f-99d3-12e6bf7ddb9c'</ShapeID>
<Messages>
	<MsgInfo><name>msgEmployee</name><part>part</part><schema>POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee+Insert</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>149</Line><Position>13</Position><ShapeID>'298b9d1b-5c25-42eb-bdb3-300fe66d208c'</ShapeID>
<Messages>
	<MsgInfo><name>msgEmployee</name><part>part</part><schema>POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee+Insert</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='bea9b33d-f812-4ad4-830c-97cd44534b39' LowerBound='1.1' HigherBound='35.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC.BizTalk.AlwaysEncrypted' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='66d1e647-7982-4491-9a4d-e93a4b4376f2' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiveEmployeePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e80b47d8-12b2-4368-9667-e59ac5288370' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmployeeOperation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='770069e3-4bfa-43ef-980f-abfe9d5ac1ec' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.51'>
                    <om:Property Name='Ref' Value='POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee.Insert' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='65f3ac9b-1c20-48e7-baa0-71efe052371f' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SQLEmployeeInsertPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7daa82ce-cec2-42fa-a0ae-30d704de3ecc' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Insert' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='7a436fe9-6048-4e82-9019-7ac3e0ad2cfe' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.51'>
                    <om:Property Name='Ref' Value='POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee.Insert' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='4311434b-6b53-4555-93fb-f4a80694faf2' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='34.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='POCInsertIntoSQL' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='63c12843-b8c3-4361-9372-5c894eaa9e86' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='e0892531-072d-472f-99d3-12e6bf7ddb9c' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='30.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveEmployeePort' />
                    <om:Property Name='MessageName' Value='msgEmployee' />
                    <om:Property Name='OperationName' Value='EmployeeOperation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive XML' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='298b9d1b-5c25-42eb-bdb3-300fe66d208c' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='32.1'>
                    <om:Property Name='PortName' Value='SQLEmployeeInsertPort' />
                    <om:Property Name='MessageName' Value='msgEmployee' />
                    <om:Property Name='OperationName' Value='Insert' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send XML' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='40a41268-762f-428a-90e8-1592625ceab7' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.BizTalk.AlwaysEncrypted.ReceiveEmployeePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveEmployeePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c8701153-9862-418e-a9b1-a7a6da594576' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='088addfc-7880-4f95-9104-0530348c7e82' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='8' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC.BizTalk.AlwaysEncrypted.SQLEmployeeInsertPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLEmployeeInsertPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='14241e50-18d1-4f2d-8bf2-4186783abc0e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='72e8371c-a1e5-4fa1-a3bb-134881dc8614' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee.Insert' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgEmployee' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __POCInsertIntoSQL_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __POCInsertIntoSQL_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "POCInsertIntoSQL")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                POCInsertIntoSQL __svc__ = (POCInsertIntoSQL)_service;
                __POCInsertIntoSQL_root_0 __ctx0__ = (__POCInsertIntoSQL_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SQLEmployeeInsertPort != null)
                {
                    __svc__.SQLEmployeeInsertPort.Close(this, null);
                    __svc__.SQLEmployeeInsertPort = null;
                }
                if (__svc__.ReceiveEmployeePort != null)
                {
                    __svc__.ReceiveEmployeePort.Close(this, null);
                    __svc__.ReceiveEmployeePort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __POCInsertIntoSQL_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __POCInsertIntoSQL_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "POCInsertIntoSQL")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                POCInsertIntoSQL __svc__ = (POCInsertIntoSQL)_service;
                __POCInsertIntoSQL_1 __ctx1__ = (__POCInsertIntoSQL_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgEmployee != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgEmployee);
                    __ctx1__.__msgEmployee = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgEmployee")]
            public __messagetype_POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert __msgEmployee;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveEmployeePort")]
        internal ReceiveEmployeePortType ReceiveEmployeePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SQLEmployeeInsertPort")]
        internal SQLEmployeeInsertPortType SQLEmployeeInsertPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceiveEmployeePortType.EmployeeOperation},
                                               typeof(POCInsertIntoSQL).GetField("ReceiveEmployeePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(POCInsertIntoSQL), "ReceiveEmployeePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SQLEmployeeInsertPortType.Insert},
                                               typeof(POCInsertIntoSQL).GetField("SQLEmployeeInsertPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(POCInsertIntoSQL), "SQLEmployeeInsertPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "e0892531-072d-472f-99d3-12e6bf7ddb9c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "e0892531-072d-472f-99d3-12e6bf7ddb9c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "298b9d1b-5c25-42eb-bdb3-300fe66d208c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "298b9d1b-5c25-42eb-bdb3-300fe66d208c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,5,5,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,3,4,5,5,5,5,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __POCInsertIntoSQL_root_0 __ctx0__ = (__POCInsertIntoSQL_root_0)_stateMgrs[0];
            __POCInsertIntoSQL_1 __ctx1__ = (__POCInsertIntoSQL_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveEmployeePort = new ReceiveEmployeePortType(0, this);
                SQLEmployeeInsertPort = new SQLEmployeeInsertPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveEmployeePort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __POCInsertIntoSQL_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __POCInsertIntoSQL_root_0 __ctx0__ = (__POCInsertIntoSQL_root_0)_stateMgrs[0];
            __POCInsertIntoSQL_1 __ctx1__ = (__POCInsertIntoSQL_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ReceiveEmployeePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgEmployee != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgEmployee);
                __ctx1__.__msgEmployee = new __messagetype_POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert("msgEmployee", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgEmployee);
                ReceiveEmployeePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgEmployee, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveEmployeePort != null)
                {
                    ReceiveEmployeePort.Close(__ctx1__, __seg__);
                    ReceiveEmployeePort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgEmployee);
                    __edata.PortName = @"ReceiveEmployeePort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SQLEmployeeInsertPort.SendMessage(0, __ctx1__.__msgEmployee, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SQLEmployeeInsertPort != null)
                {
                    SQLEmployeeInsertPort.Close(__ctx1__, __seg__);
                    SQLEmployeeInsertPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgEmployee);
                    __edata.PortName = @"SQLEmployeeInsertPort";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgEmployee != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgEmployee);
                    __ctx1__.__msgEmployee = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 12;
            case 12:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee.Insert _schema = new POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee.Insert();

        public __POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee.Insert",
        new System.Type[]{
            typeof(POC.BizTalk.AlwaysEncrypted.SQL_TableOperation_dbo_Employee.Insert)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/Employee#Insert"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert__ part;

        private void __CreatePartWrappers()
        {
            part = new __POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_POC_BizTalk_AlwaysEncrypted_SQL_TableOperation_dbo_Employee_Insert(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
