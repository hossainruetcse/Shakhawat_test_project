// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "JSON\WelcomeJson.json"
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
using __WCoSchema__ = global::Shakhawat_test_project.JSON.WelcomeJson.CorporationsElementJson.JsonByExample.Schema;
using __WConame__ = global::Shakhawat_test_project.JSON.WelcomeJson.CorporationsElementJson.Input.name;
using __TArray1__ = global::Starcounter.Templates.TArray<global::Shakhawat_test_project.JSON.WelcomeJson.CorporationsElementJson>;
using __WelcomeJ1__ = global::Shakhawat_test_project.JSON.WelcomeJson.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson>;
using __Arr1__ = global::Starcounter.Arr<global::Shakhawat_test_project.JSON.WelcomeJson.CorporationsElementJson>;
using __WelcomeJ2__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input;
using __WeHtml__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.Html;
using __WeNewName__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.NewName;
using __WeCorporat2__ = global::Shakhawat_test_project.JSON.WelcomeJson.CorporationsElementJson.Input;
using __WeNewOffic__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.NewOfficeName;
using __WeCreateOf__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.CreateOfficeTrigger;
using __WesortByHo__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.sortByHomesTrigger;
using __WesortByTo__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.sortByTotalTrigger;
using __WesortByAv__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.sortByAverageTrigger;
using __WesortByTr__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.sortByTrendTrigger;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __WeCreateTr__ = global::Shakhawat_test_project.JSON.WelcomeJson.Input.CreateTrigger;
using __WeCorporat1__ = global::Shakhawat_test_project.JSON.WelcomeJson.CorporationsElementJson.JsonByExample;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __WeCorporat__ = global::Shakhawat_test_project.JSON.WelcomeJson.CorporationsElementJson;
using __WelcomeJ__ = global::Shakhawat_test_project.JSON.WelcomeJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __WeSchema__ = global::Shakhawat_test_project.JSON.WelcomeJson.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __WeOfficesE__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson;
using __WOfSchema__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.JsonByExample.Schema;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __WeOfficesE2__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.Input;
using __WOfID__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.Input.ID;
using __WOfname__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.Input.name;
using __WOfnumber_o__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.Input.number_of_home_sold;
using __WOftotal_co__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.Input.total_commission;
using __WOftrend__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.Input.trend;
using __WOfaverage___ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.Input.average_commission;
using __TArray__ = global::Starcounter.Templates.TArray<global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson>;
using __WeOfficesE1__ = global::Shakhawat_test_project.JSON.WelcomeJson.OfficesElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class WelcomeJson_json : s::TemplateAttribute {
    
    #line hidden
    public class Offices : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Corporations : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class WelcomeJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __WeSchema__ DefaultTemplate = new __WeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public WelcomeJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public WelcomeJson(__WeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __WeSchema__ Template { get { return (__WeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__WelcomeJ__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/TestApp/Welcome.html";
                Html.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                NewName = Add<__TString__>("NewName$");
                NewName.DefaultValue = "";
                NewName.Editable = true;
                NewName.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__NewName__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__NewName__ = (System.String)_v_; }, false);
                NewOfficeName = Add<__TString__>("NewOfficeName$");
                NewOfficeName.DefaultValue = "";
                NewOfficeName.Editable = true;
                NewOfficeName.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__NewOfficeName__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__NewOfficeName__ = (System.String)_v_; }, false);
                Offices = Add<__TArray__>("Offices$", bind:"Offices");
                Offices.Editable = true;
                Offices.SetCustomGetElementType((arr) => { return __WeOfficesE__.DefaultTemplate;});
                Offices.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__Offices__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__Offices__ = (__Arr__)_v_; }, false);
                Corporations = Add<__TArray1__>("Corporations$", bind:"Corporations");
                Corporations.Editable = true;
                Corporations.SetCustomGetElementType((arr) => { return __WeCorporat__.DefaultTemplate;});
                Corporations.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__Corporations__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__Corporations__ = (__Arr1__)_v_; }, false);
                CreateTrigger = Add<__TLong__>("CreateTrigger$");
                CreateTrigger.DefaultValue = 0L;
                CreateTrigger.Editable = true;
                CreateTrigger.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__CreateTrigger__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__CreateTrigger__ = (System.Int64)_v_; }, false);
                CreateTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateTrigger() { App = (WelcomeJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WelcomeJson)pup).Handle((Input.CreateTrigger)input); });
                CreateOfficeTrigger = Add<__TLong__>("CreateOfficeTrigger$");
                CreateOfficeTrigger.DefaultValue = 0L;
                CreateOfficeTrigger.Editable = true;
                CreateOfficeTrigger.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__CreateOfficeTrigger__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__CreateOfficeTrigger__ = (System.Int64)_v_; }, false);
                CreateOfficeTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateOfficeTrigger() { App = (WelcomeJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WelcomeJson)pup).Handle((Input.CreateOfficeTrigger)input); });
                sortByHomesTrigger = Add<__TLong__>("sortByHomesTrigger$");
                sortByHomesTrigger.DefaultValue = 0L;
                sortByHomesTrigger.Editable = true;
                sortByHomesTrigger.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__sortByHomesTrigger__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__sortByHomesTrigger__ = (System.Int64)_v_; }, false);
                sortByHomesTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.sortByHomesTrigger() { App = (WelcomeJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WelcomeJson)pup).Handle((Input.sortByHomesTrigger)input); });
                sortByTotalTrigger = Add<__TLong__>("sortByTotalTrigger$");
                sortByTotalTrigger.DefaultValue = 0L;
                sortByTotalTrigger.Editable = true;
                sortByTotalTrigger.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__sortByTotalTrigger__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__sortByTotalTrigger__ = (System.Int64)_v_; }, false);
                sortByAverageTrigger = Add<__TLong__>("sortByAverageTrigger$");
                sortByAverageTrigger.DefaultValue = 0L;
                sortByAverageTrigger.Editable = true;
                sortByAverageTrigger.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__sortByAverageTrigger__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__sortByAverageTrigger__ = (System.Int64)_v_; }, false);
                sortByTrendTrigger = Add<__TLong__>("sortByTrendTrigger$");
                sortByTrendTrigger.DefaultValue = 0L;
                sortByTrendTrigger.Editable = true;
                sortByTrendTrigger.SetCustomAccessors((_p_) => { return ((__WelcomeJ__)_p_).__bf__sortByTrendTrigger__; }, (_p_, _v_) => { ((__WelcomeJ__)_p_).__bf__sortByTrendTrigger__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __WelcomeJ__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ NewName;
            public __TString__ NewOfficeName;
            public __TArray__ Offices;
            public __TArray1__ Corporations;
            public __TLong__ CreateTrigger;
            public __TLong__ CreateOfficeTrigger;
            public __TLong__ sortByHomesTrigger;
            public __TLong__ sortByTotalTrigger;
            public __TLong__ sortByAverageTrigger;
            public __TLong__ sortByTrendTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewName {
    #line 3 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.NewName.Getter(this); }
        #line 3 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.NewName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewOfficeName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewOfficeName {
    #line 4 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.NewOfficeName.Getter(this); }
        #line 4 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.NewOfficeName.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Offices__;
    #line default
    #line hidden
    private __Arr1__ __bf__Corporations__;
    #line default
    #line hidden
    private System.Int64 __bf__CreateTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateTrigger {
    #line 7 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.CreateTrigger.Getter(this); }
        #line 7 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.CreateTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CreateOfficeTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateOfficeTrigger {
    #line 8 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.CreateOfficeTrigger.Getter(this); }
        #line 8 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.CreateOfficeTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__sortByHomesTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 sortByHomesTrigger {
    #line 9 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.sortByHomesTrigger.Getter(this); }
        #line 9 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.sortByHomesTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__sortByTotalTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 sortByTotalTrigger {
    #line 10 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.sortByTotalTrigger.Getter(this); }
        #line 10 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.sortByTotalTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__sortByAverageTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 sortByAverageTrigger {
    #line 11 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.sortByAverageTrigger.Getter(this); }
        #line 11 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.sortByAverageTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__sortByTrendTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 sortByTrendTrigger {
    #line 12 "JSON\WelcomeJson.json"
        get {
        #line hidden
            return Template.sortByTrendTrigger.Getter(this); }
        #line 12 "JSON\WelcomeJson.json"
        set {
        #line hidden
            Template.sortByTrendTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class OfficesElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WOfSchema__ DefaultTemplate = new __WOfSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public OfficesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public OfficesElementJson(__WOfSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WOfSchema__ Template { get { return (__WOfSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeOfficesE__);
                    Properties.ClearExposed();
                    ID = Add<__TString__>("ID$");
                    ID.DefaultValue = "";
                    ID.Editable = true;
                    ID.SetCustomAccessors((_p_) => { return ((__WeOfficesE__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__WeOfficesE__)_p_).__bf__ID__ = (System.String)_v_; }, false);
                    name = Add<__TString__>("name$");
                    name.DefaultValue = "";
                    name.Editable = true;
                    name.SetCustomAccessors((_p_) => { return ((__WeOfficesE__)_p_).__bf__name__; }, (_p_, _v_) => { ((__WeOfficesE__)_p_).__bf__name__ = (System.String)_v_; }, false);
                    number_of_home_sold = Add<__TLong__>("number_of_home_sold$");
                    number_of_home_sold.DefaultValue = 0L;
                    number_of_home_sold.Editable = true;
                    number_of_home_sold.SetCustomAccessors((_p_) => { return ((__WeOfficesE__)_p_).__bf__number_of_home_sold__; }, (_p_, _v_) => { ((__WeOfficesE__)_p_).__bf__number_of_home_sold__ = (System.Int64)_v_; }, false);
                    total_commission = Add<__TLong__>("total_commission$");
                    total_commission.DefaultValue = 0L;
                    total_commission.Editable = true;
                    total_commission.SetCustomAccessors((_p_) => { return ((__WeOfficesE__)_p_).__bf__total_commission__; }, (_p_, _v_) => { ((__WeOfficesE__)_p_).__bf__total_commission__ = (System.Int64)_v_; }, false);
                    trend = Add<__TLong__>("trend$");
                    trend.DefaultValue = 0L;
                    trend.Editable = true;
                    trend.SetCustomAccessors((_p_) => { return ((__WeOfficesE__)_p_).__bf__trend__; }, (_p_, _v_) => { ((__WeOfficesE__)_p_).__bf__trend__ = (System.Int64)_v_; }, false);
                    average_commission = Add<__TLong__>("average_commission$");
                    average_commission.DefaultValue = 0L;
                    average_commission.Editable = true;
                    average_commission.SetCustomAccessors((_p_) => { return ((__WeOfficesE__)_p_).__bf__average_commission__; }, (_p_, _v_) => { ((__WeOfficesE__)_p_).__bf__average_commission__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeOfficesE__(this) { Parent = parent }; }
                public __TString__ ID;
                public __TString__ name;
                public __TLong__ number_of_home_sold;
                public __TLong__ total_commission;
                public __TLong__ trend;
                public __TLong__ average_commission;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__ID__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ID {
        #line 5 "JSON\WelcomeJson.json"
            get {
            #line hidden
                return Template.ID.Getter(this); }
            #line 5 "JSON\WelcomeJson.json"
            set {
            #line hidden
                Template.ID.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String name {
        #line 5 "JSON\WelcomeJson.json"
            get {
            #line hidden
                return Template.name.Getter(this); }
            #line 5 "JSON\WelcomeJson.json"
            set {
            #line hidden
                Template.name.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__number_of_home_sold__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 number_of_home_sold {
        #line 5 "JSON\WelcomeJson.json"
            get {
            #line hidden
                return Template.number_of_home_sold.Getter(this); }
            #line 5 "JSON\WelcomeJson.json"
            set {
            #line hidden
                Template.number_of_home_sold.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__total_commission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 total_commission {
        #line 5 "JSON\WelcomeJson.json"
            get {
            #line hidden
                return Template.total_commission.Getter(this); }
            #line 5 "JSON\WelcomeJson.json"
            set {
            #line hidden
                Template.total_commission.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__trend__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 trend {
        #line 5 "JSON\WelcomeJson.json"
            get {
            #line hidden
                return Template.trend.Getter(this); }
            #line 5 "JSON\WelcomeJson.json"
            set {
            #line hidden
                Template.trend.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__average_commission__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 average_commission {
        #line 5 "JSON\WelcomeJson.json"
            get {
            #line hidden
                return Template.average_commission.Getter(this); }
            #line 5 "JSON\WelcomeJson.json"
            set {
            #line hidden
                Template.average_commission.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ID : Input<__WeOfficesE__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class name : Input<__WeOfficesE__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class number_of_home_sold : Input<__WeOfficesE__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class total_commission : Input<__WeOfficesE__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class trend : Input<__WeOfficesE__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class average_commission : Input<__WeOfficesE__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CorporationsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WCoSchema__ DefaultTemplate = new __WCoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CorporationsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CorporationsElementJson(__WCoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WCoSchema__ Template { get { return (__WCoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeCorporat__);
                    Properties.ClearExposed();
                    name = Add<__TString__>("name$");
                    name.DefaultValue = "";
                    name.Editable = true;
                    name.SetCustomAccessors((_p_) => { return ((__WeCorporat__)_p_).__bf__name__; }, (_p_, _v_) => { ((__WeCorporat__)_p_).__bf__name__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeCorporat__(this) { Parent = parent }; }
                public __TString__ name;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String name {
        #line 6 "JSON\WelcomeJson.json"
            get {
            #line hidden
                return Template.name.Getter(this); }
            #line 6 "JSON\WelcomeJson.json"
            set {
            #line hidden
                Template.name.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class name : Input<__WeCorporat__, __TString__, string> {
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
        public class Html : Input<__WelcomeJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewName : Input<__WelcomeJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewOfficeName : Input<__WelcomeJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CreateTrigger : Input<__WelcomeJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CreateOfficeTrigger : Input<__WelcomeJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class sortByHomesTrigger : Input<__WelcomeJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class sortByTotalTrigger : Input<__WelcomeJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class sortByAverageTrigger : Input<__WelcomeJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class sortByTrendTrigger : Input<__WelcomeJ__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
