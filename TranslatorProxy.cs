﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :2.0.50727.5448
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.MT.Web.Service.V2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TranslateOptions", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    public partial class TranslateOptions : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CategoryField;
        
        private string ContentTypeField;
        
        private string ReservedFlagsField;
        
        private string StateField;
        
        private string UriField;
        
        private string UserField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Category
        {
            get
            {
                return this.CategoryField;
            }
            set
            {
                this.CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ContentType
        {
            get
            {
                return this.ContentTypeField;
            }
            set
            {
                this.ContentTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ReservedFlags
        {
            get
            {
                return this.ReservedFlagsField;
            }
            set
            {
                this.ReservedFlagsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Uri
        {
            get
            {
                return this.UriField;
            }
            set
            {
                this.UriField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTranslationsResponse", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    public partial class GetTranslationsResponse : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string FromField;
        
        private string StateField;
        
        private Microsoft.MT.Web.Service.V2.TranslationMatch[] TranslationsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string From
        {
            get
            {
                return this.FromField;
            }
            set
            {
                this.FromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Microsoft.MT.Web.Service.V2.TranslationMatch[] Translations
        {
            get
            {
                return this.TranslationsField;
            }
            set
            {
                this.TranslationsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TranslationMatch", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    public partial class TranslationMatch : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CountField;
        
        private string ErrorField;
        
        private int MatchDegreeField;
        
        private string MatchedOriginalTextField;
        
        private int RatingField;
        
        private string TranslatedTextField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Count
        {
            get
            {
                return this.CountField;
            }
            set
            {
                this.CountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Error
        {
            get
            {
                return this.ErrorField;
            }
            set
            {
                this.ErrorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int MatchDegree
        {
            get
            {
                return this.MatchDegreeField;
            }
            set
            {
                this.MatchDegreeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MatchedOriginalText
        {
            get
            {
                return this.MatchedOriginalTextField;
            }
            set
            {
                this.MatchedOriginalTextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Rating
        {
            get
            {
                return this.RatingField;
            }
            set
            {
                this.RatingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string TranslatedText
        {
            get
            {
                return this.TranslatedTextField;
            }
            set
            {
                this.TranslatedTextField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Translation", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    public partial class Translation : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string OriginalTextField;
        
        private int RatingField;
        
        private int SequenceField;
        
        private string TranslatedTextField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string OriginalText
        {
            get
            {
                return this.OriginalTextField;
            }
            set
            {
                this.OriginalTextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int Rating
        {
            get
            {
                return this.RatingField;
            }
            set
            {
                this.RatingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int Sequence
        {
            get
            {
                return this.SequenceField;
            }
            set
            {
                this.SequenceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string TranslatedText
        {
            get
            {
                return this.TranslatedTextField;
            }
            set
            {
                this.TranslatedTextField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TranslateArrayResponse", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    public partial class TranslateArrayResponse : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ErrorField;
        
        private string FromField;
        
        private int[] OriginalTextSentenceLengthsField;
        
        private string StateField;
        
        private string TranslatedTextField;
        
        private int[] TranslatedTextSentenceLengthsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Error
        {
            get
            {
                return this.ErrorField;
            }
            set
            {
                this.ErrorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string From
        {
            get
            {
                return this.FromField;
            }
            set
            {
                this.FromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int[] OriginalTextSentenceLengths
        {
            get
            {
                return this.OriginalTextSentenceLengthsField;
            }
            set
            {
                this.OriginalTextSentenceLengthsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TranslatedText
        {
            get
            {
                return this.TranslatedTextField;
            }
            set
            {
                this.TranslatedTextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int[] TranslatedTextSentenceLengths
        {
            get
            {
                return this.TranslatedTextSentenceLengthsField;
            }
            set
            {
                this.TranslatedTextSentenceLengthsField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://api.microsofttranslator.com/V2", ConfigurationName="LanguageService")]
public interface LanguageService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/AddTranslation", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/AddTranslationResponse")]
    void AddTranslation(string appId, string originalText, string translatedText, string from, string to, int rating, string contentType, string category, string user, string uri);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/BreakSentences", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/BreakSentencesResponse")]
    int[] BreakSentences(string appId, string text, string language);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/Detect", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/DetectResponse")]
    string Detect(string appId, string text);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/DetectArray", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/DetectArrayResponse")]
    string[] DetectArray(string appId, string[] texts);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetAppIdToken", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetAppIdTokenResponse")]
    string GetAppIdToken(string appId, int minRatingRead, int maxRatingWrite, int expireSeconds);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetLanguageNames", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetLanguageNamesResponse")]
    string[] GetLanguageNames(string appId, string locale, string[] languageCodes);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetLanguagesForSpeak", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetLanguagesForSpeakRespons" +
        "e")]
    string[] GetLanguagesForSpeak(string appId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetLanguagesForTranslate", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetLanguagesForTranslateRes" +
        "ponse")]
    string[] GetLanguagesForTranslate(string appId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetTranslations", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetTranslationsResponse")]
    Microsoft.MT.Web.Service.V2.GetTranslationsResponse GetTranslations(string appId, string text, string from, string to, int maxTranslations, Microsoft.MT.Web.Service.V2.TranslateOptions options);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/Translate", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/TranslateResponse")]
    string Translate(string appId, string text, string from, string to, string contentType, string category);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/AddTranslationArray", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/AddTranslationArrayResponse" +
        "")]
    void AddTranslationArray(string appId, Microsoft.MT.Web.Service.V2.Translation[] translations, string from, string to, Microsoft.MT.Web.Service.V2.TranslateOptions options);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetTranslationsArray", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetTranslationsArrayRespons" +
        "e")]
    Microsoft.MT.Web.Service.V2.GetTranslationsResponse[] GetTranslationsArray(string appId, string[] texts, string from, string to, int maxTranslations, Microsoft.MT.Web.Service.V2.TranslateOptions options);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/Speak", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/SpeakResponse")]
    string Speak(string appId, string text, string language, string format, string options);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/TranslateArray", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/TranslateArrayResponse")]
    Microsoft.MT.Web.Service.V2.TranslateArrayResponse[] TranslateArray(string appId, string[] texts, string from, string to, Microsoft.MT.Web.Service.V2.TranslateOptions options);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface LanguageServiceChannel : LanguageService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class LanguageServiceClient : System.ServiceModel.ClientBase<LanguageService>, LanguageService
{
    
    public LanguageServiceClient()
    {
    }
    
    public LanguageServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public LanguageServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public LanguageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public LanguageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void AddTranslation(string appId, string originalText, string translatedText, string from, string to, int rating, string contentType, string category, string user, string uri)
    {
        base.Channel.AddTranslation(appId, originalText, translatedText, from, to, rating, contentType, category, user, uri);
    }
    
    public int[] BreakSentences(string appId, string text, string language)
    {
        return base.Channel.BreakSentences(appId, text, language);
    }
    
    public string Detect(string appId, string text)
    {
        return base.Channel.Detect(appId, text);
    }
    
    public string[] DetectArray(string appId, string[] texts)
    {
        return base.Channel.DetectArray(appId, texts);
    }
    
    public string GetAppIdToken(string appId, int minRatingRead, int maxRatingWrite, int expireSeconds)
    {
        return base.Channel.GetAppIdToken(appId, minRatingRead, maxRatingWrite, expireSeconds);
    }
    
    public string[] GetLanguageNames(string appId, string locale, string[] languageCodes)
    {
        return base.Channel.GetLanguageNames(appId, locale, languageCodes);
    }
    
    public string[] GetLanguagesForSpeak(string appId)
    {
        return base.Channel.GetLanguagesForSpeak(appId);
    }
    
    public string[] GetLanguagesForTranslate(string appId)
    {
        return base.Channel.GetLanguagesForTranslate(appId);
    }
    
    public Microsoft.MT.Web.Service.V2.GetTranslationsResponse GetTranslations(string appId, string text, string from, string to, int maxTranslations, Microsoft.MT.Web.Service.V2.TranslateOptions options)
    {
        return base.Channel.GetTranslations(appId, text, from, to, maxTranslations, options);
    }
    
    public string Translate(string appId, string text, string from, string to, string contentType, string category)
    {
        return base.Channel.Translate(appId, text, from, to, contentType, category);
    }
    
    public void AddTranslationArray(string appId, Microsoft.MT.Web.Service.V2.Translation[] translations, string from, string to, Microsoft.MT.Web.Service.V2.TranslateOptions options)
    {
        base.Channel.AddTranslationArray(appId, translations, from, to, options);
    }
    
    public Microsoft.MT.Web.Service.V2.GetTranslationsResponse[] GetTranslationsArray(string appId, string[] texts, string from, string to, int maxTranslations, Microsoft.MT.Web.Service.V2.TranslateOptions options)
    {
        return base.Channel.GetTranslationsArray(appId, texts, from, to, maxTranslations, options);
    }
    
    public string Speak(string appId, string text, string language, string format, string options)
    {
        return base.Channel.Speak(appId, text, language, format, options);
    }
    
    public Microsoft.MT.Web.Service.V2.TranslateArrayResponse[] TranslateArray(string appId, string[] texts, string from, string to, Microsoft.MT.Web.Service.V2.TranslateOptions options)
    {
        return base.Channel.TranslateArray(appId, texts, from, to, options);
    }
}
