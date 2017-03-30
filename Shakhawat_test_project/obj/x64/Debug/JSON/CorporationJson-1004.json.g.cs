// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "JSON\CorporationJson.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
using Shakhawat_test_project.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Shakhawat_test_project.JSON {
using __Cadcity__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.Input.city;
using __Corporat2__ = global::Shakhawat_test_project.JSON.CorporationJson.Input;
using __CoHtml__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.Html;
using __CoFranchis__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.FranchiseOfficeID;
using __CoID__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.ID;
using __Coname__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.name;
using __ConewName__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.newName;
using __CoNewSaleP__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.NewSalePrice;
using __CoNewComis__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.NewComissonInfo;
using __Conumber_o__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.number_of_home_sold;
using __Cototal_co__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.total_commission;
using __Cotrend__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.trend;
using __CoNewName__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.NewName;
using __CoSaveTrig__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.SaveTrigger;
using __CoRegister__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.RegisterTrigger;
using __Coaverage___ = global::Shakhawat_test_project.JSON.CorporationJson.Input.average_commission;
using __CoNewSaleS__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.NewSaleStreet;
using __CoNewSaleN__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.NewSaleNumber;
using __CoNewSaleZ__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.NewSaleZipCode;
using __CoNewSaleC__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.NewSaleCity;
using __CoNewSaleC1__ = global::Shakhawat_test_project.JSON.CorporationJson.Input.NewSaleCountry;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __Arr__ = global::Starcounter.Arr<global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson>;
using __Cadcountry__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.Input.country;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __CadzipCode__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.Input.zipCode;
using __Corporat__ = global::Shakhawat_test_project.JSON.CorporationJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CoSchema__ = global::Shakhawat_test_project.JSON.CorporationJson.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __CadSchema__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __CoTransect__ = global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson;
using __CTrSchema__ = global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson.JsonByExample.Schema;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __CoTransect1__ = global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson.JsonByExample;
using __CTrID__ = global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson.Input.ID;
using __CTrprice__ = global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson.Input.price;
using __CTrcomissio__ = global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson.Input.comission;
using __TArray__ = global::Starcounter.Templates.TArray<global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson>;
using __Corporat1__ = global::Shakhawat_test_project.JSON.CorporationJson.JsonByExample;
using __CoaddressJ__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson;
using __CoaddressJ1__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.JsonByExample;
using __CoaddressJ2__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.Input;
using __CadparentId__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.Input.parentId;
using __Cadstreet__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.Input.street;
using __Cadnumber__ = global::Shakhawat_test_project.JSON.CorporationJson.addressJson.Input.number;
using __CoTransect2__ = global::Shakhawat_test_project.JSON.CorporationJson.TransectionElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationJson_json : s::TemplateAttribute {
    
    #line hidden
    public class address : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Transection : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class CorporationJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationJson(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/TestApp/Corporations.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                address = Add<__CadSchema__>("address$", bind:"address");
                address.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__address__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__address__ = (__CoaddressJ__)_v_; }, false);
                Transection = Add<__TArray__>("Transection$", bind:"Transection");
                Transection.Editable = true;
                Transection.SetCustomGetElementType((arr) => { return __CoTransect__.DefaultTemplate;});
                Transection.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Transection__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Transection__ = (__Arr__)_v_; }, false);
                FranchiseOfficeID = Add<__TString__>("FranchiseOfficeID$", bind:"FranchiseOfficeID");
                FranchiseOfficeID.DefaultValue = "";
                FranchiseOfficeID.Editable = true;
                FranchiseOfficeID.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__FranchiseOfficeID__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__FranchiseOfficeID__ = (System.String)_v_; }, false);
                ID = Add<__TString__>("ID$");
                ID.DefaultValue = "";
                ID.Editable = true;
                ID.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__ID__ = (System.String)_v_; }, false);
                name = Add<__TString__>("name$");
                name.DefaultValue = "";
                name.Editable = true;
                name.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__name__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__name__ = (System.String)_v_; }, false);
                newName = Add<__TString__>("newName$");
                newName.DefaultValue = "";
                newName.Editable = true;
                newName.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__newName__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__newName__ = (System.String)_v_; }, false);
                NewSalePrice = Add<__TLong__>("NewSalePrice$");
                NewSalePrice.DefaultValue = 0L;
                NewSalePrice.Editable = true;
                NewSalePrice.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewSalePrice__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewSalePrice__ = (System.Int64)_v_; }, false);
                NewComissonInfo = Add<__TLong__>("NewComissonInfo$");
                NewComissonInfo.DefaultValue = 0L;
                NewComissonInfo.Editable = true;
                NewComissonInfo.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewComissonInfo__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewComissonInfo__ = (System.Int64)_v_; }, false);
                number_of_home_sold = Add<__TLong__>("number_of_home_sold$");
                number_of_home_sold.DefaultValue = 0L;
                number_of_home_sold.Editable = true;
                number_of_home_sold.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__number_of_home_sold__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__number_of_home_sold__ = (System.Int64)_v_; }, false);
                total_commission = Add<__TLong__>("total_commission$");
                total_commission.DefaultValue = 0L;
                total_commission.Editable = true;
                total_commission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__total_commission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__total_commission__ = (System.Int64)_v_; }, false);
                trend = Add<__TLong__>("trend$");
                trend.DefaultValue = 0L;
                trend.Editable = true;
                trend.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__trend__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__trend__ = (System.Int64)_v_; }, false);
                NewName = Add<__TString__>("NewName$");
                NewName.DefaultValue = "";
                NewName.Editable = true;
                NewName.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewName__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewName__ = (System.String)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger$");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.Editable = true;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (CorporationJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationJson)pup).Handle((Input.SaveTrigger)input); });
                RegisterTrigger = Add<__TLong__>("RegisterTrigger$");
                RegisterTrigger.DefaultValue = 0L;
                RegisterTrigger.Editable = true;
                RegisterTrigger.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__RegisterTrigger__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__RegisterTrigger__ = (System.Int64)_v_; }, false);
                RegisterTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.RegisterTrigger() { App = (CorporationJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationJson)pup).Handle((Input.RegisterTrigger)input); });
                average_commission = Add<__TLong__>("average_commission$");
                average_commission.DefaultValue = 0L;
                average_commission.Editable = true;
                average_commission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__average_commission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__average_commission__ = (System.Int64)_v_; }, false);
                NewSaleStreet = Add<__TLong__>("NewSaleStreet$");
                NewSaleStreet.DefaultValue = 0L;
                NewSaleStreet.Editable = true;
                NewSaleStreet.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewSaleStreet__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewSaleStreet__ = (System.Int64)_v_; }, false);
                NewSaleNumber = Add<__TLong__>("NewSaleNumber$");
                NewSaleNumber.DefaultValue = 0L;
                NewSaleNumber.Editable = true;
                NewSaleNumber.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewSaleNumber__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewSaleNumber__ = (System.Int64)_v_; }, false);
                NewSaleZipCode = Add<__TLong__>("NewSaleZipCode$");
                NewSaleZipCode.DefaultValue = 0L;
                NewSaleZipCode.Editable = true;
                NewSaleZipCode.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewSaleZipCode__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewSaleZipCode__ = (System.Int64)_v_; }, false);
                NewSaleCity = Add<__TString__>("NewSaleCity$");
                NewSaleCity.DefaultValue = "";
                NewSaleCity.Editable = true;
                NewSaleCity.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewSaleCity__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewSaleCity__ = (System.String)_v_; }, false);
                NewSaleCountry = Add<__TString__>("NewSaleCountry$");
                NewSaleCountry.DefaultValue = "";
                NewSaleCountry.Editable = true;
                NewSaleCountry.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewSaleCountry__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewSaleCountry__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __CadSchema__ address;
            public __TArray__ Transection;
            public __TString__ FranchiseOfficeID;
            public __TString__ ID;
            public __TString__ name;
            public __TString__ newName;
            public __TLong__ NewSalePrice;
            public __TLong__ NewComissonInfo;
            public __TLong__ number_of_home_sold;
            public __TLong__ total_commission;
            public __TLong__ trend;
            public __TString__ NewName;
            public __TLong__ SaveTrigger;
            public __TLong__ RegisterTrigger;
            public __TLong__ average_commission;
            public __TLong__ NewSaleStreet;
            public __TLong__ NewSaleNumber;
            public __TLong__ NewSaleZipCode;
            public __TString__ NewSaleCity;
            public __TString__ NewSaleCountry;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __CoaddressJ__ __bf__address__;
    #line default
    #line hidden
    private __Arr__ __bf__Transection__;
    #line default
    #line hidden
    private System.String __bf__FranchiseOfficeID__;
    #line default
    #line hidden
    private System.String __bf__ID__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ID {
    #line 19 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.ID.Getter(this); }
        #line 19 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.ID.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String name {
    #line 20 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.name.Getter(this); }
        #line 20 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__newName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String newName {
    #line 21 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.newName.Getter(this); }
        #line 21 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.newName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewSalePrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewSalePrice {
    #line 22 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.NewSalePrice.Getter(this); }
        #line 22 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.NewSalePrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewComissonInfo__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewComissonInfo {
    #line 23 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.NewComissonInfo.Getter(this); }
        #line 23 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.NewComissonInfo.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__number_of_home_sold__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 number_of_home_sold {
    #line 24 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.number_of_home_sold.Getter(this); }
        #line 24 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.number_of_home_sold.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__total_commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 total_commission {
    #line 25 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.total_commission.Getter(this); }
        #line 25 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.total_commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 trend {
    #line 26 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.trend.Getter(this); }
        #line 26 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.trend.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewName {
    #line 27 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.NewName.Getter(this); }
        #line 27 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.NewName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 28 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 28 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__RegisterTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 RegisterTrigger {
    #line 29 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.RegisterTrigger.Getter(this); }
        #line 29 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.RegisterTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__average_commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 average_commission {
    #line 30 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.average_commission.Getter(this); }
        #line 30 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.average_commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewSaleStreet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewSaleStreet {
    #line 31 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.NewSaleStreet.Getter(this); }
        #line 31 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.NewSaleStreet.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewSaleNumber__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewSaleNumber {
    #line 32 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.NewSaleNumber.Getter(this); }
        #line 32 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.NewSaleNumber.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewSaleZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewSaleZipCode {
    #line 33 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.NewSaleZipCode.Getter(this); }
        #line 33 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.NewSaleZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewSaleCity__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewSaleCity {
    #line 34 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.NewSaleCity.Getter(this); }
        #line 34 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.NewSaleCity.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewSaleCountry__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewSaleCountry {
    #line 35 "JSON\CorporationJson.json"
        get {
        #line hidden
            return Template.NewSaleCountry.Getter(this); }
        #line 35 "JSON\CorporationJson.json"
        set {
        #line hidden
            Template.NewSaleCountry.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class addressJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CadSchema__ DefaultTemplate = new __CadSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public addressJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public addressJson(__CadSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CadSchema__ Template { get { return (__CadSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CoaddressJ__);
                    Properties.ClearExposed();
                    parentId = Add<__TString__>("parentId$");
                    parentId.DefaultValue = "";
                    parentId.Editable = true;
                    parentId.SetCustomAccessors((_p_) => { return ((__CoaddressJ__)_p_).__bf__parentId__; }, (_p_, _v_) => { ((__CoaddressJ__)_p_).__bf__parentId__ = (System.String)_v_; }, false);
                    street = Add<__TLong__>("street$");
                    street.DefaultValue = 0L;
                    street.Editable = true;
                    street.SetCustomAccessors((_p_) => { return ((__CoaddressJ__)_p_).__bf__street__; }, (_p_, _v_) => { ((__CoaddressJ__)_p_).__bf__street__ = (System.Int64)_v_; }, false);
                    number = Add<__TLong__>("number$");
                    number.DefaultValue = 0L;
                    number.Editable = true;
                    number.SetCustomAccessors((_p_) => { return ((__CoaddressJ__)_p_).__bf__number__; }, (_p_, _v_) => { ((__CoaddressJ__)_p_).__bf__number__ = (System.Int64)_v_; }, false);
                    zipCode = Add<__TLong__>("zipCode$");
                    zipCode.DefaultValue = 0L;
                    zipCode.Editable = true;
                    zipCode.SetCustomAccessors((_p_) => { return ((__CoaddressJ__)_p_).__bf__zipCode__; }, (_p_, _v_) => { ((__CoaddressJ__)_p_).__bf__zipCode__ = (System.Int64)_v_; }, false);
                    city = Add<__TString__>("city$");
                    city.DefaultValue = "";
                    city.Editable = true;
                    city.SetCustomAccessors((_p_) => { return ((__CoaddressJ__)_p_).__bf__city__; }, (_p_, _v_) => { ((__CoaddressJ__)_p_).__bf__city__ = (System.String)_v_; }, false);
                    country = Add<__TString__>("country$");
                    country.DefaultValue = "";
                    country.Editable = true;
                    country.SetCustomAccessors((_p_) => { return ((__CoaddressJ__)_p_).__bf__country__; }, (_p_, _v_) => { ((__CoaddressJ__)_p_).__bf__country__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CoaddressJ__(this) { Parent = parent }; }
                public __TString__ parentId;
                public __TLong__ street;
                public __TLong__ number;
                public __TLong__ zipCode;
                public __TString__ city;
                public __TString__ country;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__parentId__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String parentId {
        #line 4 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.parentId.Getter(this); }
            #line 4 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.parentId.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__street__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 street {
        #line 5 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.street.Getter(this); }
            #line 5 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.street.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__number__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 number {
        #line 6 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.number.Getter(this); }
            #line 6 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.number.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__zipCode__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 zipCode {
        #line 7 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.zipCode.Getter(this); }
            #line 7 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.zipCode.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__city__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String city {
        #line 8 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.city.Getter(this); }
            #line 8 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.city.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__country__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String country {
        #line 9 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.country.Getter(this); }
            #line 9 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.country.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class parentId : Input<__CoaddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class street : Input<__CoaddressJ__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class number : Input<__CoaddressJ__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class zipCode : Input<__CoaddressJ__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class city : Input<__CoaddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class country : Input<__CoaddressJ__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class TransectionElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CTrSchema__ DefaultTemplate = new __CTrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public TransectionElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public TransectionElementJson(__CTrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CTrSchema__ Template { get { return (__CTrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CoTransect__);
                    Properties.ClearExposed();
                    ID = Add<__TString__>("ID$");
                    ID.DefaultValue = "";
                    ID.Editable = true;
                    ID.SetCustomAccessors((_p_) => { return ((__CoTransect__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__CoTransect__)_p_).__bf__ID__ = (System.String)_v_; }, false);
                    price = Add<__TLong__>("price$");
                    price.DefaultValue = 0L;
                    price.Editable = true;
                    price.SetCustomAccessors((_p_) => { return ((__CoTransect__)_p_).__bf__price__; }, (_p_, _v_) => { ((__CoTransect__)_p_).__bf__price__ = (System.Int64)_v_; }, false);
                    comission = Add<__TLong__>("comission$");
                    comission.DefaultValue = 0L;
                    comission.Editable = true;
                    comission.SetCustomAccessors((_p_) => { return ((__CoTransect__)_p_).__bf__comission__; }, (_p_, _v_) => { ((__CoTransect__)_p_).__bf__comission__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CoTransect__(this) { Parent = parent }; }
                public __TString__ ID;
                public __TLong__ price;
                public __TLong__ comission;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__ID__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ID {
        #line 13 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.ID.Getter(this); }
            #line 13 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.ID.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__price__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 price {
        #line 14 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.price.Getter(this); }
            #line 14 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.price.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__comission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 comission {
        #line 15 "JSON\CorporationJson.json"
            get {
            #line hidden
                return Template.comission.Getter(this); }
            #line 15 "JSON\CorporationJson.json"
            set {
            #line hidden
                Template.comission.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ID : Input<__CoTransect__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class price : Input<__CoTransect__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class comission : Input<__CoTransect__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FranchiseOfficeID : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ID : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class name : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class newName : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewSalePrice : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewComissonInfo : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class number_of_home_sold : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class total_commission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class trend : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewName : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class RegisterTrigger : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class average_commission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewSaleStreet : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewSaleNumber : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewSaleZipCode : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewSaleCity : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewSaleCountry : Input<__Corporat__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
