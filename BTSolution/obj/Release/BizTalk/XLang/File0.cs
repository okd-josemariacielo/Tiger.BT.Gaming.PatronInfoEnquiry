
#pragma warning disable 162

namespace Tiger.BT.Gaming.PlayerInfoEnquiry
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "S2SMessagePostOperation",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest), 
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_HAlo_S2S_Service : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_HAlo_S2S_Service(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_HAlo_S2S_Service(PortType_HAlo_S2S_Service p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_HAlo_S2S_Service p = new PortType_HAlo_S2S_Service(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo S2SMessagePostOperation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "S2SMessagePostOperation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_HAlo_S2S_Service),
            typeof(__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest),
            typeof(__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "S2SMessagePostOperation" ] = S2SMessagePostOperation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "PatronInfoEnquiry",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.__messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest), 
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.__messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_PatronInfoEnquiry : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_PatronInfoEnquiry(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_PatronInfoEnquiry(PortType_PatronInfoEnquiry p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_PatronInfoEnquiry p = new PortType_PatronInfoEnquiry(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo PatronInfoEnquiry = new Microsoft.XLANGs.Core.OperationInfo
        (
            "PatronInfoEnquiry",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_PatronInfoEnquiry),
            typeof(__messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest),
            typeof(__messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "PatronInfoEnquiry" ] = PatronInfoEnquiry;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.__messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_FCMS_Test_RQ : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_FCMS_Test_RQ(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_FCMS_Test_RQ(PortType_FCMS_Test_RQ p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_FCMS_Test_RQ p = new PortType_FCMS_Test_RQ(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_FCMS_Test_RQ),
            typeof(__messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_HAlo_Test_RQ : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_HAlo_Test_RQ(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_HAlo_Test_RQ(PortType_HAlo_Test_RQ p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_HAlo_Test_RQ p = new PortType_HAlo_Test_RQ(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_HAlo_Test_RQ),
            typeof(__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_HAlo_Test_RS : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_HAlo_Test_RS(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_HAlo_Test_RS(PortType_HAlo_Test_RS p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_HAlo_Test_RS p = new PortType_HAlo_Test_RS(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_HAlo_Test_RS),
            typeof(__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.__messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_FCMS_Test_RS : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_FCMS_Test_RS(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_FCMS_Test_RS(PortType_FCMS_Test_RS p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_FCMS_Test_RS p = new PortType_FCMS_Test_RS(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_FCMS_Test_RS),
            typeof(__messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 525 "C:\Anand\GIT\Tiger.BT.Gaming\Tiger.BT.Gaming.PlayerEnquiry\Orchestrations\PatronInfoEnquiry.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_PatronInfoEnquiry", "PatronInfoEnquiry", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_PatronInfoEnquiry),
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_FCMS_Test_RQ),
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_HAlo_Test_RQ),
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_HAlo_S2S_Service),
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_HAlo_Test_RS),
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_FCMS_Test_RS)
        },
        new System.String[] {
            "Port_PatronInfoEnquiry",
            "Port_FCMS_Test_RQ",
            "Port_HAlo_Test_RQ",
            "Port_HAlo_S2S_Service",
            "Port_HAlo_Test_RS",
            "Port_FCMS_Test_RS"
        },
        new System.Type[] {
            null,
            null,
            null,
            null,
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
    sealed internal class Orch_PatronInfoEnquiry : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Orch_PatronInfoEnquiry));
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

        static Orch_PatronInfoEnquiry()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2)
            };

            _Locks = 0;
            _rootContext = new __Orch_PatronInfoEnquiry_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Orch_PatronInfoEnquiry(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Orch_PatronInfoEnquiry", tracker)
        {
            ConstructorHelper();
        }

        public Orch_PatronInfoEnquiry(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Orch_PatronInfoEnquiry")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>39ab6fd4-b493-4656-afd1-f1124aa3ed8d</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>403f7f0c-6ec1-42f3-a362-bd9454c0a460</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_FCMS_Req</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>beb3af9e-3b6d-422a-b55f-731a4fe929eb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_PatronInfoEnquiry</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>fb8ab1e6-25e3-4a00-9ce7-6e9be508746c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Test_FCMS_RQ</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c97acaca-bd01-4ed8-81d4-180d112b5657</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_HAlo_Req</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>12edc056-6cd9-45f8-9cf7-cb14fa52cc10</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_FCMSReqToHAloReq</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7a061e1e-6165-46d6-9256-54b8744597ba</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0cdf82ee-0688-49a1-a200-f107e779ea81</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3a71c665-ed62-4962-8bee-112dc0c89140</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>6e03da08-4e89-45f9-9502-84a8726d7307</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_HAlo_Svc_Req</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>da1a8bde-e63d-474e-b3d6-611dbd461f46</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_HAloReqToHAloSvcReq</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>e03861af-d888-4669-bc60-8ec9734ddadc</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>560301ab-3999-4146-ba59-36d1944a1be0</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>64edb9d1-a62e-4152-b5ba-476c7b352c35</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>8bd99a3a-4b8b-4eb9-a84a-03b8f4a51363</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Test_HAlo_RQ</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>4a1d9e70-828f-4998-ae9a-9ce6d9b47e54</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_HAlo_Req</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f0e2a7c5-80c9-4266-86f9-eb06a919b0c7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_HAlo_Res</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1f6f2931-9ad8-4a2f-803f-5a901ae26edb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Test_HAlo_Req</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>075eb646-4fb8-47bc-b4b3-437b508c36fe</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_HAlo_Res</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>2098d472-d4dd-499a-a923-403cc1fbb931</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_HAlo_Res</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>21a73d5e-37d9-4659-a671-99c72f6ae71b</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>0ed64b3c-ba2a-42f2-ae34-1df350d92ef5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_FCMS_Res</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>3ed3e8e3-0170-41e3-8280-ef7f5dacc44a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_HAloResToFCMSRes</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>6ffdcda2-f20a-4833-bdd9-d8a3f6607541</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3e5eeba3-07fd-4c58-a77d-2cac63018de1</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>4bf72195-d9ba-4204-8f20-2f80a8b1963e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>ccff16f4-6248-40ca-8cbe-1fc5abc139c6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Test_FCMS_Res</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>52b97aaf-82ca-4948-a171-39b4ebe67aa6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_FCMS_Res</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Orch_PatronInfoEnquiry'</ActionName><IsAtomic>0</IsAtomic><Line>525</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>549</Line><Position>22</Position><ShapeID>'403f7f0c-6ec1-42f3-a362-bd9454c0a460'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_FCMS_RQ_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>552</Line><Position>13</Position><ShapeID>'beb3af9e-3b6d-422a-b55f-731a4fe929eb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>557</Line><Position>21</Position><ShapeID>'fb8ab1e6-25e3-4a00-9ce7-6e9be508746c'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_FCMS_RQ_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>559</Line><Position>21</Position><ShapeID>'c97acaca-bd01-4ed8-81d4-180d112b5657'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_RQ_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_FCMS_RQ_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>565</Line><Position>21</Position><ShapeID>'6e03da08-4e89-45f9-9502-84a8726d7307'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RQ</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_HAlo_RQ_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>571</Line><Position>21</Position><ShapeID>'8bd99a3a-4b8b-4eb9-a84a-03b8f4a51363'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RQ</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>573</Line><Position>21</Position><ShapeID>'4a1d9e70-828f-4998-ae9a-9ce6d9b47e54'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RQ</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>575</Line><Position>21</Position><ShapeID>'f0e2a7c5-80c9-4266-86f9-eb06a919b0c7'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RS</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>577</Line><Position>21</Position><ShapeID>'1f6f2931-9ad8-4a2f-803f-5a901ae26edb'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RS</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>579</Line><Position>21</Position><ShapeID>'075eb646-4fb8-47bc-b4b3-437b508c36fe'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_RS_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>587</Line><Position>21</Position><ShapeID>'0ed64b3c-ba2a-42f2-ae34-1df350d92ef5'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_FCMS_RS_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_HAlo_RS_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>593</Line><Position>21</Position><ShapeID>'ccff16f4-6248-40ca-8cbe-1fc5abc139c6'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_FCMS_RS_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>595</Line><Position>21</Position><ShapeID>'52b97aaf-82ca-4948-a171-39b4ebe67aa6'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_FCMS_RS_Type</name><part>part</part><schema>Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='da5c43e1-9a53-4639-a7ff-ca54fe7abe5b' LowerBound='1.1' HigherBound='123.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Tiger.BT.Gaming.PlayerInfoEnquiry' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='29fcbb28-b3e8-4e8e-bdc5-1ddc6b04d617' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_HAlo_S2S_Service' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='fc995904-af3f-4840-8fcc-52d8906d7a73' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:operation name=&quot;S2SMessagePostOperation&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='S2SMessagePostOperation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='71e0e823-bcf1-45c6-9f87-28d9cde17663' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.133' HigherBound='8.252'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:output message=&quot;http://www.gamingstandards.com/s2s/wsdl/v1.1/S2SMessageService.wsdl:S2SMessagePostOperationResponse&quot;/&gt;&#xD;&#xA;Action=&quot;http://www.gamingstandards.com/s2s/wsdl/v1.1/S2SMessageService.wsdl/S2SMessageServiceBinding/S2SMessagePostOperationResponse&quot;' />
                    <om:Property Name='Name' Value='S2SMessagePostOperationResponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='e9e99185-2267-4dea-aa4e-8a32d96ff7c9' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.131'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:input message=&quot;http://www.gamingstandards.com/s2s/wsdl/v1.1/S2SMessageService.wsdl:S2SMessagePostOperationRequest&quot;/&gt;&#xD;&#xA;Action=&quot;http://www.gamingstandards.com:8080/S2SWebsite/services/SlotSystemHost&quot;' />
                    <om:Property Name='Name' Value='S2SMessagePostOperationRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='8e3dcd27-63c8-4228-a5a6-7fc6082a83a8' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_PatronInfoEnquiry' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='3b70f176-7af6-4c2a-9ed6-47d414cdaa18' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PatronInfoEnquiry' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='eed64fda-4d5a-4890-ab58-99672d23728a' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='5ecfcfae-45bb-4d46-bbe1-e700997ce6cf' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.52' HigherBound='15.90'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='20c4d5a8-3a6a-4acc-8c6c-e47cb6b25e2c' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_FCMS_Test_RQ' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f4deab94-fefc-467b-b67d-b59310feefdf' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='0c0cd19f-5a8f-4f8b-af73-bc1438944b90' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='3f444ee7-e4b3-42c6-b798-e5731ce9d94f' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_HAlo_Test_RQ' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='5c734f20-ca8d-426a-8fef-0150c4af3c20' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='96ae4de8-db75-4a6a-8c83-37af79730c56' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.131'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='557c3978-6ba4-4efb-8ed7-73ee42ec2dbb' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_HAlo_Test_RS' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='82b5f0bf-ebf7-4351-8e0b-c556841b6427' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='13e54434-af3e-4769-8d44-a05e893ca45c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.132'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='a40f85c0-a0f5-4342-a69d-e42c9d1cb02d' ParentLink='Module_PortType' LowerBound='39.1' HigherBound='46.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_FCMS_Test_RS' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e8b5e1bc-0c07-46fa-847d-4a4f1c677cae' ParentLink='PortType_OperationDeclaration' LowerBound='41.1' HigherBound='45.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='6b837d60-5b85-4bb4-b415-87b09264b7e0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='43.13' HigherBound='43.51'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='fcbe14ed-85a7-4f99-851e-8b291a9de012' ParentLink='Module_ServiceDeclaration' LowerBound='46.1' HigherBound='122.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Orch_PatronInfoEnquiry' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='bd23c7e4-6bde-4373-a8f8-4260b2d0fa5e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.Deserialization.Deserialization' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='var_deserialization' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4fa0ad81-a19a-49a0-8696-bc65296fcd4d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='61.1' HigherBound='62.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HAlo_Svc_RS' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='10d6933d-44f9-4392-9327-86bac23ddb8c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HAlo_Svc_RQ' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='fdc7e311-cc98-4ced-ae88-8f6515f1eba8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='63.1' HigherBound='64.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HAlo_RS_Type' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='fffdde6c-f290-4543-9a38-6a9ab92bd73b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='64.1' HigherBound='65.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HAlo_RQ_Type' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='9afbcd3b-3add-439a-b936-764fcfb54cf4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_FCMS_RS_Type' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c386fb5e-ddbe-42d0-9aff-a234910f8717' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_FCMS_RQ_Type' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='39ab6fd4-b493-4656-afd1-f1124aa3ed8d' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='403f7f0c-6ec1-42f3-a362-bd9454c0a460' ParentLink='ServiceBody_Statement' LowerBound='70.1' HigherBound='73.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_PatronInfoEnquiry' />
                    <om:Property Name='MessageName' Value='Msg_FCMS_RQ_Type' />
                    <om:Property Name='OperationName' Value='PatronInfoEnquiry' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_FCMS_Req' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='beb3af9e-3b6d-422a-b55f-731a4fe929eb' ParentLink='ServiceBody_Statement' LowerBound='73.1' HigherBound='120.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_PatronInfoEnquiry' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Send' OID='fb8ab1e6-25e3-4a00-9ce7-6e9be508746c' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='80.1'>
                        <om:Property Name='PortName' Value='Port_FCMS_Test_RQ' />
                        <om:Property Name='MessageName' Value='Msg_FCMS_RQ_Type' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_Test_FCMS_RQ' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='c97acaca-bd01-4ed8-81d4-180d112b5657' ParentLink='ComplexStatement_Statement' LowerBound='80.1' HigherBound='86.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_HAlo_Req' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='12edc056-6cd9-45f8-9cf7-cb14fa52cc10' ParentLink='ComplexStatement_Statement' LowerBound='83.1' HigherBound='85.1'>
                            <om:Property Name='ClassName' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Maps.PatronInfoEnquiryFCMSReqToHAloReq' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_FCMSReqToHAloReq' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='7a061e1e-6165-46d6-9256-54b8744597ba' ParentLink='Transform_InputMessagePartRef' LowerBound='84.130' HigherBound='84.146'>
                                <om:Property Name='MessageRef' Value='Msg_FCMS_RQ_Type' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='0cdf82ee-0688-49a1-a200-f107e779ea81' ParentLink='Transform_OutputMessagePartRef' LowerBound='84.36' HigherBound='84.52'>
                                <om:Property Name='MessageRef' Value='Msg_HAlo_RQ_Type' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='3a71c665-ed62-4962-8bee-112dc0c89140' ParentLink='Construct_MessageRef' LowerBound='81.31' HigherBound='81.47'>
                            <om:Property Name='Ref' Value='Msg_HAlo_RQ_Type' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Construct' OID='6e03da08-4e89-45f9-9502-84a8726d7307' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='92.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_HAlo_Svc_Req' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='da1a8bde-e63d-474e-b3d6-611dbd461f46' ParentLink='ComplexStatement_Statement' LowerBound='89.1' HigherBound='91.1'>
                            <om:Property Name='ClassName' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Maps.PatronInfoEnquiryHAloReqToHAloSvcReq' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_HAloReqToHAloSvcReq' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessagePartRef' OID='e03861af-d888-4669-bc60-8ec9734ddadc' ParentLink='Transform_InputMessagePartRef' LowerBound='90.132' HigherBound='90.148'>
                                <om:Property Name='MessageRef' Value='Msg_HAlo_RQ_Type' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_3' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='560301ab-3999-4146-ba59-36d1944a1be0' ParentLink='Transform_OutputMessagePartRef' LowerBound='90.36' HigherBound='90.51'>
                                <om:Property Name='MessageRef' Value='Msg_HAlo_Svc_RQ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_4' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='64edb9d1-a62e-4152-b5ba-476c7b352c35' ParentLink='Construct_MessageRef' LowerBound='87.31' HigherBound='87.46'>
                            <om:Property Name='Ref' Value='Msg_HAlo_Svc_RQ' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='8bd99a3a-4b8b-4eb9-a84a-03b8f4a51363' ParentLink='ComplexStatement_Statement' LowerBound='92.1' HigherBound='94.1'>
                        <om:Property Name='PortName' Value='Port_HAlo_Test_RQ' />
                        <om:Property Name='MessageName' Value='Msg_HAlo_Svc_RQ' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_Test_HAlo_RQ' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='4a1d9e70-828f-4998-ae9a-9ce6d9b47e54' ParentLink='ComplexStatement_Statement' LowerBound='94.1' HigherBound='96.1'>
                        <om:Property Name='PortName' Value='Port_HAlo_S2S_Service' />
                        <om:Property Name='MessageName' Value='Msg_HAlo_Svc_RQ' />
                        <om:Property Name='OperationName' Value='S2SMessagePostOperation' />
                        <om:Property Name='OperationMessageName' Value='S2SMessagePostOperationRequest' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_HAlo_Req' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='f0e2a7c5-80c9-4266-86f9-eb06a919b0c7' ParentLink='ComplexStatement_Statement' LowerBound='96.1' HigherBound='98.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='Port_HAlo_S2S_Service' />
                        <om:Property Name='MessageName' Value='Msg_HAlo_Svc_RS' />
                        <om:Property Name='OperationName' Value='S2SMessagePostOperation' />
                        <om:Property Name='OperationMessageName' Value='S2SMessagePostOperationResponse' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive_HAlo_Res' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='1f6f2931-9ad8-4a2f-803f-5a901ae26edb' ParentLink='ComplexStatement_Statement' LowerBound='98.1' HigherBound='100.1'>
                        <om:Property Name='PortName' Value='Port_HAlo_Test_RS' />
                        <om:Property Name='MessageName' Value='Msg_HAlo_Svc_RS' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_Test_HAlo_Req' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='075eb646-4fb8-47bc-b4b3-437b508c36fe' ParentLink='ComplexStatement_Statement' LowerBound='100.1' HigherBound='108.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_HAlo_Res' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageAssignment' OID='2098d472-d4dd-499a-a923-403cc1fbb931' ParentLink='ComplexStatement_Statement' LowerBound='103.1' HigherBound='107.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;AnandInfo&quot;,&quot;DeserializeMessage-Start&quot;,System.Diagnostics.EventLogEntryType.Information);&#xD;&#xA;Msg_HAlo_RS_Type = var_deserialization.DeserializeMessage(Msg_HAlo_Svc_RS);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;AnandInfo&quot;,&quot;DeserializeMessage-End&quot;,System.Diagnostics.EventLogEntryType.Information);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_HAlo_Res' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='21a73d5e-37d9-4659-a671-99c72f6ae71b' ParentLink='Construct_MessageRef' LowerBound='101.31' HigherBound='101.47'>
                            <om:Property Name='Ref' Value='Msg_HAlo_RS_Type' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Construct' OID='0ed64b3c-ba2a-42f2-ae34-1df350d92ef5' ParentLink='ComplexStatement_Statement' LowerBound='108.1' HigherBound='114.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_FCMS_Res' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='3ed3e8e3-0170-41e3-8280-ef7f5dacc44a' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='113.1'>
                            <om:Property Name='ClassName' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.Maps.PatronInfoEnquiryHAloResToFCMSRes' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_HAloResToFCMSRes' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='6ffdcda2-f20a-4833-bdd9-d8a3f6607541' ParentLink='Transform_InputMessagePartRef' LowerBound='112.130' HigherBound='112.146'>
                                <om:Property Name='MessageRef' Value='Msg_HAlo_RS_Type' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_5' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='3e5eeba3-07fd-4c58-a77d-2cac63018de1' ParentLink='Transform_OutputMessagePartRef' LowerBound='112.36' HigherBound='112.52'>
                                <om:Property Name='MessageRef' Value='Msg_FCMS_RS_Type' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_6' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='4bf72195-d9ba-4204-8f20-2f80a8b1963e' ParentLink='Construct_MessageRef' LowerBound='109.31' HigherBound='109.47'>
                            <om:Property Name='Ref' Value='Msg_FCMS_RS_Type' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='ccff16f4-6248-40ca-8cbe-1fc5abc139c6' ParentLink='ComplexStatement_Statement' LowerBound='114.1' HigherBound='116.1'>
                        <om:Property Name='PortName' Value='Port_FCMS_Test_RS' />
                        <om:Property Name='MessageName' Value='Msg_FCMS_RS_Type' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_Test_FCMS_Res' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='52b97aaf-82ca-4948-a171-39b4ebe67aa6' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='118.1'>
                        <om:Property Name='PortName' Value='Port_PatronInfoEnquiry' />
                        <om:Property Name='MessageName' Value='Msg_FCMS_RS_Type' />
                        <om:Property Name='OperationName' Value='PatronInfoEnquiry' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_FCMS_Res' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e578b407-f77a-4060-9ec7-a395e5e43941' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='49.1' HigherBound='51.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='6' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_PatronInfoEnquiry' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_PatronInfoEnquiry' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7d748628-c3cb-4572-8bf3-f3873ad26252' ParentLink='PortDeclaration_CLRAttribute' LowerBound='49.1' HigherBound='50.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1eba6c97-06ed-4bf6-b765-1993e08f09c4' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='51.1' HigherBound='53.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='29' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_HAlo_S2S_Service' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_HAlo_S2S_Service' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='574e69d2-26e5-40a8-bac6-332ff4903b45' ParentLink='PortDeclaration_CLRAttribute' LowerBound='51.1' HigherBound='52.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='72ecd306-0f6c-4bfa-bb29-82c27400716a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='53.1' HigherBound='55.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='17' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_FCMS_Test_RQ' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_FCMS_Test_RQ' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7bb20afc-a3d7-4ee3-8db2-f987881c2982' ParentLink='PortDeclaration_CLRAttribute' LowerBound='53.1' HigherBound='54.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3e150dd6-2960-4b35-9521-40b11c4deef1' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='55.1' HigherBound='57.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='23' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_HAlo_Test_RQ' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_HAlo_Test_RQ' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8eda1f59-7f38-4aff-9f7f-29cf16905be2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='55.1' HigherBound='56.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='9423da6e-eff0-41ec-801b-8a4782727373' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='57.1' HigherBound='59.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='34' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_HAlo_Test_RS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_HAlo_Test_RS' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='10a6ff59-e164-4381-a37d-fba41a2aa693' ParentLink='PortDeclaration_CLRAttribute' LowerBound='57.1' HigherBound='58.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a2fde21f-7d99-4f25-b74f-afeaa2f146de' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='59.1' HigherBound='61.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='43' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.PlayerInfoEnquiry.PortType_FCMS_Test_RS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_FCMS_Test_RS' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='4ef7a98f-b398-44de-855d-6b812faa6f52' ParentLink='PortDeclaration_CLRAttribute' LowerBound='59.1' HigherBound='60.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Orch_PatronInfoEnquiry_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Orch_PatronInfoEnquiry_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Orch_PatronInfoEnquiry")
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
                Orch_PatronInfoEnquiry __svc__ = (Orch_PatronInfoEnquiry)_service;
                __Orch_PatronInfoEnquiry_root_0 __ctx0__ = (__Orch_PatronInfoEnquiry_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_HAlo_S2S_Service != null)
                {
                    __svc__.Port_HAlo_S2S_Service.Close(this, null);
                    __svc__.Port_HAlo_S2S_Service = null;
                }
                if (__svc__.Port_FCMS_Test_RQ != null)
                {
                    __svc__.Port_FCMS_Test_RQ.Close(this, null);
                    __svc__.Port_FCMS_Test_RQ = null;
                }
                if (__svc__.Port_HAlo_Test_RQ != null)
                {
                    __svc__.Port_HAlo_Test_RQ.Close(this, null);
                    __svc__.Port_HAlo_Test_RQ = null;
                }
                if (__svc__.Port_PatronInfoEnquiry != null)
                {
                    __svc__.Port_PatronInfoEnquiry.Close(this, null);
                    __svc__.Port_PatronInfoEnquiry = null;
                }
                if (__svc__.Port_HAlo_Test_RS != null)
                {
                    __svc__.Port_HAlo_Test_RS.Close(this, null);
                    __svc__.Port_HAlo_Test_RS = null;
                }
                if (__svc__.Port_FCMS_Test_RS != null)
                {
                    __svc__.Port_FCMS_Test_RS.Close(this, null);
                    __svc__.Port_FCMS_Test_RS = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Orch_PatronInfoEnquiry_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Orch_PatronInfoEnquiry_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Orch_PatronInfoEnquiry")
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
                Orch_PatronInfoEnquiry __svc__ = (Orch_PatronInfoEnquiry)_service;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HAlo_Svc_RS")]
            public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse __Msg_HAlo_Svc_RS;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HAlo_Svc_RQ")]
            public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest __Msg_HAlo_Svc_RQ;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HAlo_RS_Type")]
            public __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse __Msg_HAlo_RS_Type;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HAlo_RQ_Type")]
            public __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest __Msg_HAlo_RQ_Type;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_FCMS_RS_Type")]
            public __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse __Msg_FCMS_RS_Type;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_FCMS_RQ_Type")]
            public __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest __Msg_FCMS_RQ_Type;
            [Microsoft.XLANGs.Core.UserVariableAttribute("var_deserialization")]
            internal Tiger.BT.Gaming.Deserialization.Deserialization __var_deserialization;
        }


        [System.SerializableAttribute]
        public class ____scope33_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope33_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope33")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Orch_PatronInfoEnquiry __svc__ = (Orch_PatronInfoEnquiry)_service;
                __Orch_PatronInfoEnquiry_1 __ctx1__ = (__Orch_PatronInfoEnquiry_1)(__svc__._stateMgrs[1]);
                __Orch_PatronInfoEnquiry_root_0 __ctx0__ = (__Orch_PatronInfoEnquiry_root_0)(__svc__._stateMgrs[0]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_FCMS_RQ_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_FCMS_RQ_Type);
                    __ctx1__.__Msg_FCMS_RQ_Type = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_Svc_RQ != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __ctx1__.__Msg_HAlo_Svc_RQ = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_FCMS_RS_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_FCMS_RS_Type);
                    __ctx1__.__Msg_FCMS_RS_Type = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_Svc_RS != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RS);
                    __ctx1__.__Msg_HAlo_Svc_RS = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__var_deserialization = null;
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_RS_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RS_Type);
                    __ctx1__.__Msg_HAlo_RS_Type = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_RQ_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RQ_Type);
                    __ctx1__.__Msg_HAlo_RQ_Type = null;
                }
                base.Finally();
            }

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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_PatronInfoEnquiry")]
        internal PortType_PatronInfoEnquiry Port_PatronInfoEnquiry;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_FCMS_Test_RQ")]
        internal PortType_FCMS_Test_RQ Port_FCMS_Test_RQ;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_HAlo_Test_RQ")]
        internal PortType_HAlo_Test_RQ Port_HAlo_Test_RQ;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_HAlo_S2S_Service")]
        internal PortType_HAlo_S2S_Service Port_HAlo_S2S_Service;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_HAlo_Test_RS")]
        internal PortType_HAlo_Test_RS Port_HAlo_Test_RS;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_FCMS_Test_RS")]
        internal PortType_FCMS_Test_RS Port_FCMS_Test_RS;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_PatronInfoEnquiry.PatronInfoEnquiry},
                                               typeof(Orch_PatronInfoEnquiry).GetField("Port_PatronInfoEnquiry", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orch_PatronInfoEnquiry), "Port_PatronInfoEnquiry"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_FCMS_Test_RQ.Operation_1},
                                               typeof(Orch_PatronInfoEnquiry).GetField("Port_FCMS_Test_RQ", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orch_PatronInfoEnquiry), "Port_FCMS_Test_RQ"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_HAlo_Test_RQ.Operation_1},
                                               typeof(Orch_PatronInfoEnquiry).GetField("Port_HAlo_Test_RQ", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orch_PatronInfoEnquiry), "Port_HAlo_Test_RQ"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_HAlo_S2S_Service.S2SMessagePostOperation},
                                               typeof(Orch_PatronInfoEnquiry).GetField("Port_HAlo_S2S_Service", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orch_PatronInfoEnquiry), "Port_HAlo_S2S_Service"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_HAlo_Test_RS.Operation_1},
                                               typeof(Orch_PatronInfoEnquiry).GetField("Port_HAlo_Test_RS", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orch_PatronInfoEnquiry), "Port_HAlo_Test_RS"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_FCMS_Test_RS.Operation_1},
                                               typeof(Orch_PatronInfoEnquiry).GetField("Port_FCMS_Test_RS", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orch_PatronInfoEnquiry), "Port_FCMS_Test_RS"),
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
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                h[_portInfo[4].Name] = _portInfo[4];
                h[_portInfo[5].Name] = _portInfo[5];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "403f7f0c-6ec1-42f3-a362-bd9454c0a460", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "403f7f0c-6ec1-42f3-a362-bd9454c0a460", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "beb3af9e-3b6d-422a-b55f-731a4fe929eb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "fb8ab1e6-25e3-4a00-9ce7-6e9be508746c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "fb8ab1e6-25e3-4a00-9ce7-6e9be508746c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "c97acaca-bd01-4ed8-81d4-180d112b5657", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "c97acaca-bd01-4ed8-81d4-180d112b5657", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "6e03da08-4e89-45f9-9502-84a8726d7307", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "6e03da08-4e89-45f9-9502-84a8726d7307", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "8bd99a3a-4b8b-4eb9-a84a-03b8f4a51363", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "8bd99a3a-4b8b-4eb9-a84a-03b8f4a51363", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "4a1d9e70-828f-4998-ae9a-9ce6d9b47e54", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "4a1d9e70-828f-4998-ae9a-9ce6d9b47e54", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "f0e2a7c5-80c9-4266-86f9-eb06a919b0c7", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "f0e2a7c5-80c9-4266-86f9-eb06a919b0c7", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "1f6f2931-9ad8-4a2f-803f-5a901ae26edb", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "1f6f2931-9ad8-4a2f-803f-5a901ae26edb", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "075eb646-4fb8-47bc-b4b3-437b508c36fe", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "075eb646-4fb8-47bc-b4b3-437b508c36fe", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "0ed64b3c-ba2a-42f2-ae34-1df350d92ef5", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "0ed64b3c-ba2a-42f2-ae34-1df350d92ef5", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "ccff16f4-6248-40ca-8cbe-1fc5abc139c6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "ccff16f4-6248-40ca-8cbe-1fc5abc139c6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "52b97aaf-82ca-4948-a171-39b4ebe67aa6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "52b97aaf-82ca-4948-a171-39b4ebe67aa6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "beb3af9e-3b6d-422a-b55f-731a4fe929eb", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,4,28,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,6,7,8,8,9,10,10,11,12,12,12,13,14,14,14,15,16,16,17,18,18,18,19,20,20,21,22,22,23,24,24,24,25,26,26,26,27,27,27,27,};

        public static int[][] __progressLocations = new int[3] [] {__progressLocation0,__progressLocation1,__progressLocation2};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Orch_PatronInfoEnquiry_1 __ctx1__ = (__Orch_PatronInfoEnquiry_1)_stateMgrs[1];
            __Orch_PatronInfoEnquiry_root_0 __ctx0__ = (__Orch_PatronInfoEnquiry_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Port_PatronInfoEnquiry = new PortType_PatronInfoEnquiry(0, this);
                Port_HAlo_S2S_Service = new PortType_HAlo_S2S_Service(3, this);
                Port_FCMS_Test_RQ = new PortType_FCMS_Test_RQ(1, this);
                Port_HAlo_Test_RQ = new PortType_HAlo_Test_RQ(2, this);
                Port_HAlo_Test_RS = new PortType_HAlo_Test_RS(4, this);
                Port_FCMS_Test_RS = new PortType_FCMS_Test_RS(5, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_PatronInfoEnquiry, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Orch_PatronInfoEnquiry_1(this);
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
            __Orch_PatronInfoEnquiry_1 __ctx1__ = (__Orch_PatronInfoEnquiry_1)_stateMgrs[1];
            __Orch_PatronInfoEnquiry_root_0 __ctx0__ = (__Orch_PatronInfoEnquiry_root_0)_stateMgrs[0];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__var_deserialization = default(Tiger.BT.Gaming.Deserialization.Deserialization);
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
                if (!Port_PatronInfoEnquiry.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Msg_FCMS_RQ_Type != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_FCMS_RQ_Type);
                __ctx1__.__Msg_FCMS_RQ_Type = new __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest("Msg_FCMS_RQ_Type", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg_FCMS_RQ_Type);
                Port_PatronInfoEnquiry.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg_FCMS_RQ_Type, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Msg_FCMS_RQ_Type);
                    __edata.PortName = @"Port_PatronInfoEnquiry";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__var_deserialization = new Tiger.BT.Gaming.Deserialization.Deserialization();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[5],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 13;
            case 13:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Orch_PatronInfoEnquiry_1 __ctx1__ = (__Orch_PatronInfoEnquiry_1)_stateMgrs[1];
            __Orch_PatronInfoEnquiry_root_0 __ctx0__ = (__Orch_PatronInfoEnquiry_root_0)_stateMgrs[0];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

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
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_FCMS_Test_RQ.SendMessage(0, __ctx1__.__Msg_FCMS_RQ_Type, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Port_FCMS_Test_RQ != null)
                {
                    Port_FCMS_Test_RQ.Close(__ctx2__, __seg__);
                    Port_FCMS_Test_RQ = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_FCMS_RQ_Type);
                    __edata.PortName = @"Port_FCMS_Test_RQ";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest __Msg_HAlo_RQ_Type = new __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest("Msg_HAlo_RQ_Type", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.Maps.PatronInfoEnquiryFCMSReqToHAloReq), new object[] {__Msg_HAlo_RQ_Type.part}, new object[] {__ctx1__.__Msg_FCMS_RQ_Type.part});

                    if (__ctx1__.__Msg_HAlo_RQ_Type != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RQ_Type);
                    __ctx1__.__Msg_HAlo_RQ_Type = __Msg_HAlo_RQ_Type;
                    __ctx1__.RefMessage(__ctx1__.__Msg_HAlo_RQ_Type);
                }
                __ctx1__.__Msg_HAlo_RQ_Type.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_RQ_Type);
                    __edata.Messages.Add(__ctx1__.__Msg_FCMS_RQ_Type);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_FCMS_RQ_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_FCMS_RQ_Type);
                    __ctx1__.__Msg_FCMS_RQ_Type = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest __Msg_HAlo_Svc_RQ = new __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest("Msg_HAlo_Svc_RQ", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.Maps.PatronInfoEnquiryHAloReqToHAloSvcReq), new object[] {__Msg_HAlo_Svc_RQ.part}, new object[] {__ctx1__.__Msg_HAlo_RQ_Type.part});

                    if (__ctx1__.__Msg_HAlo_Svc_RQ != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __ctx1__.__Msg_HAlo_Svc_RQ = __Msg_HAlo_Svc_RQ;
                    __ctx1__.RefMessage(__ctx1__.__Msg_HAlo_Svc_RQ);
                }
                __ctx1__.__Msg_HAlo_Svc_RQ.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_RQ_Type);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_RQ_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RQ_Type);
                    __ctx1__.__Msg_HAlo_RQ_Type = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_HAlo_Test_RQ.SendMessage(0, __ctx1__.__Msg_HAlo_Svc_RQ, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Port_HAlo_Test_RQ != null)
                {
                    Port_HAlo_Test_RQ.Close(__ctx2__, __seg__);
                    Port_HAlo_Test_RQ = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __edata.PortName = @"Port_HAlo_Test_RQ";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_HAlo_S2S_Service.SendMessage(0, __ctx1__.__Msg_HAlo_Svc_RQ, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __edata.PortName = @"Port_HAlo_S2S_Service";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_Svc_RQ != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __ctx1__.__Msg_HAlo_Svc_RQ = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!Port_HAlo_S2S_Service.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__Msg_HAlo_Svc_RS != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RS);
                __ctx1__.__Msg_HAlo_Svc_RS = new __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse("Msg_HAlo_Svc_RS", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg_HAlo_Svc_RS);
                Port_HAlo_S2S_Service.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg_HAlo_Svc_RS, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if (Port_HAlo_S2S_Service != null)
                {
                    Port_HAlo_S2S_Service.Close(__ctx2__, __seg__);
                    Port_HAlo_S2S_Service = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RS);
                    __edata.PortName = @"Port_HAlo_S2S_Service";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_HAlo_Test_RS.SendMessage(0, __ctx1__.__Msg_HAlo_Svc_RS, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Port_HAlo_Test_RS != null)
                {
                    Port_HAlo_Test_RS.Close(__ctx2__, __seg__);
                    Port_HAlo_Test_RS = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RS);
                    __edata.PortName = @"Port_HAlo_Test_RS";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                {
                    __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse __Msg_HAlo_RS_Type = new __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse("Msg_HAlo_RS_Type", __ctx1__);

                    System.Diagnostics.EventLog.WriteEntry("AnandInfo", "DeserializeMessage-Start", System.Diagnostics.EventLogEntryType.Information);
                    __Msg_HAlo_RS_Type.part.LoadFrom(__ctx1__.__var_deserialization.DeserializeMessage(CreateMessageWrapperForUserCode(__ctx1__.__Msg_HAlo_Svc_RS)));
                    if (__ctx1__ != null)
                        __ctx1__.__var_deserialization = null;
                    if (__ctx1__ != null && __ctx1__.__Msg_HAlo_Svc_RS != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RS);
                        __ctx1__.__Msg_HAlo_Svc_RS = null;
                    }
                    System.Diagnostics.EventLog.WriteEntry("AnandInfo", "DeserializeMessage-End", System.Diagnostics.EventLogEntryType.Information);

                    if (__ctx1__.__Msg_HAlo_RS_Type != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RS_Type);
                    __ctx1__.__Msg_HAlo_RS_Type = __Msg_HAlo_RS_Type;
                    __ctx1__.RefMessage(__ctx1__.__Msg_HAlo_RS_Type);
                }
                __ctx1__.__Msg_HAlo_RS_Type.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_RS_Type);
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                {
                    __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse __Msg_FCMS_RS_Type = new __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse("Msg_FCMS_RS_Type", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.Maps.PatronInfoEnquiryHAloResToFCMSRes), new object[] {__Msg_FCMS_RS_Type.part}, new object[] {__ctx1__.__Msg_HAlo_RS_Type.part});

                    if (__ctx1__.__Msg_FCMS_RS_Type != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_FCMS_RS_Type);
                    __ctx1__.__Msg_FCMS_RS_Type = __Msg_FCMS_RS_Type;
                    __ctx1__.RefMessage(__ctx1__.__Msg_FCMS_RS_Type);
                }
                __ctx1__.__Msg_FCMS_RS_Type.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_FCMS_RS_Type);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_RS_Type);
                    Tracker.FireEvent(__eventLocations[23],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_RS_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RS_Type);
                    __ctx1__.__Msg_HAlo_RS_Type = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_FCMS_Test_RS.SendMessage(0, __ctx1__.__Msg_FCMS_RS_Type, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Port_FCMS_Test_RS != null)
                {
                    Port_FCMS_Test_RS.Close(__ctx2__, __seg__);
                    Port_FCMS_Test_RS = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_FCMS_RS_Type);
                    __edata.PortName = @"Port_FCMS_Test_RS";
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_PatronInfoEnquiry.SendMessage(0, __ctx1__.__Msg_FCMS_RS_Type, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Port_PatronInfoEnquiry != null)
                {
                    Port_PatronInfoEnquiry.Close(__ctx2__, __seg__);
                    Port_PatronInfoEnquiry = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_FCMS_RS_Type);
                    __edata.PortName = @"Port_PatronInfoEnquiry";
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_FCMS_RS_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_FCMS_RS_Type);
                    __ctx1__.__Msg_FCMS_RS_Type = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 42;
            case 42:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{8369E76E-8C42-4DBA-8DD4-28EDB7994D20}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest _schema = new Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest();

        public __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/wsdl/v1.1/S2SMessageService.wsdl#s2sRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse _schema = new Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse();

        public __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/wsdl/v1.1/S2SMessageService.wsdl#s2sResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest _schema = new Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest();

        public __Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest__)
        },
        0,
        @"http://TRLEI.Integration.BizTalk.PatronInfoEnquiryRequest#PatronInfoEnquiryRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse _schema = new Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse();

        public __Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse__)
        },
        0,
        @"http://TRLEI.Integration.BizTalk.PatronInfoEnquiryResponse#PatronInfoEnquiryResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_PlayerInfoEnquiry_Schemas_FCMS_PatronInfoEnquiryResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse _schema = new Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse();

        public __Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/schemas/v1.2.6/#s2sMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest _schema = new Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest();

        public __Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/schemas/v1.2.6/#s2sMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_PlayerEnquiry_Schemas_HAlo_BallyGetPlayerInfoRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
