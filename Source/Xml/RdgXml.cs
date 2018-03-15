using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuctor.Xml
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RDCMan
    {

        private decimal versionField;

        private RDCManFile fileField;

        private byte schemaVersionField;

        /// <remarks/>
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public RDCManFile file
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte schemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFile
    {

        private RDCManFileProperties propertiesField;

        private RDCManFileGroup[] groupField;

        /// <remarks/>
        public RDCManFileProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group")]
        public RDCManFileGroup[] group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileProperties
    {

        private string nameField;

        private string expandedField;

        private object commentField;

        private RDCManFilePropertiesLogonCredentials logonCredentialsField;

        private RDCManFilePropertiesConnectionSettings connectionSettingsField;

        private RDCManFilePropertiesGatewaySettings gatewaySettingsField;

        private RDCManFilePropertiesRemoteDesktop remoteDesktopField;

        private RDCManFilePropertiesLocalResources localResourcesField;

        private RDCManFilePropertiesSecuritySettings securitySettingsField;

        private RDCManFilePropertiesDisplaySettings displaySettingsField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string expanded
        {
            get
            {
                return this.expandedField;
            }
            set
            {
                this.expandedField = value;
            }
        }

        /// <remarks/>
        public object comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public RDCManFilePropertiesLogonCredentials logonCredentials
        {
            get
            {
                return this.logonCredentialsField;
            }
            set
            {
                this.logonCredentialsField = value;
            }
        }

        /// <remarks/>
        public RDCManFilePropertiesConnectionSettings connectionSettings
        {
            get
            {
                return this.connectionSettingsField;
            }
            set
            {
                this.connectionSettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFilePropertiesGatewaySettings gatewaySettings
        {
            get
            {
                return this.gatewaySettingsField;
            }
            set
            {
                this.gatewaySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFilePropertiesRemoteDesktop remoteDesktop
        {
            get
            {
                return this.remoteDesktopField;
            }
            set
            {
                this.remoteDesktopField = value;
            }
        }

        /// <remarks/>
        public RDCManFilePropertiesLocalResources localResources
        {
            get
            {
                return this.localResourcesField;
            }
            set
            {
                this.localResourcesField = value;
            }
        }

        /// <remarks/>
        public RDCManFilePropertiesSecuritySettings securitySettings
        {
            get
            {
                return this.securitySettingsField;
            }
            set
            {
                this.securitySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFilePropertiesDisplaySettings displaySettings
        {
            get
            {
                return this.displaySettingsField;
            }
            set
            {
                this.displaySettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFilePropertiesLogonCredentials
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFilePropertiesConnectionSettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFilePropertiesGatewaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFilePropertiesRemoteDesktop
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFilePropertiesLocalResources
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFilePropertiesSecuritySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFilePropertiesDisplaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroup
    {

        private RDCManFileGroupProperties propertiesField;

        private RDCManFileGroupGroup[] groupField;

        private RDCManFileGroupServer[] serverField;

        /// <remarks/>
        public RDCManFileGroupProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group")]
        public RDCManFileGroupGroup[] group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("server")]
        public RDCManFileGroupServer[] server
        {
            get
            {
                return this.serverField;
            }
            set
            {
                this.serverField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupProperties
    {

        private string nameField;

        private string expandedField;

        private object commentField;

        private RDCManFileGroupPropertiesLogonCredentials logonCredentialsField;

        private RDCManFileGroupPropertiesConnectionSettings connectionSettingsField;

        private RDCManFileGroupPropertiesGatewaySettings gatewaySettingsField;

        private RDCManFileGroupPropertiesRemoteDesktop remoteDesktopField;

        private RDCManFileGroupPropertiesLocalResources localResourcesField;

        private RDCManFileGroupPropertiesSecuritySettings securitySettingsField;

        private RDCManFileGroupPropertiesDisplaySettings displaySettingsField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string expanded
        {
            get
            {
                return this.expandedField;
            }
            set
            {
                this.expandedField = value;
            }
        }

        /// <remarks/>
        public object comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupPropertiesLogonCredentials logonCredentials
        {
            get
            {
                return this.logonCredentialsField;
            }
            set
            {
                this.logonCredentialsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupPropertiesConnectionSettings connectionSettings
        {
            get
            {
                return this.connectionSettingsField;
            }
            set
            {
                this.connectionSettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupPropertiesGatewaySettings gatewaySettings
        {
            get
            {
                return this.gatewaySettingsField;
            }
            set
            {
                this.gatewaySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupPropertiesRemoteDesktop remoteDesktop
        {
            get
            {
                return this.remoteDesktopField;
            }
            set
            {
                this.remoteDesktopField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupPropertiesLocalResources localResources
        {
            get
            {
                return this.localResourcesField;
            }
            set
            {
                this.localResourcesField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupPropertiesSecuritySettings securitySettings
        {
            get
            {
                return this.securitySettingsField;
            }
            set
            {
                this.securitySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupPropertiesDisplaySettings displaySettings
        {
            get
            {
                return this.displaySettingsField;
            }
            set
            {
                this.displaySettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupPropertiesLogonCredentials
    {

        private string userNameField;

        private string domainField;

        private RDCManFileGroupPropertiesLogonCredentialsPassword passwordField;

        private string inheritField;

        /// <remarks/>
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupPropertiesLogonCredentialsPassword password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupPropertiesLogonCredentialsPassword
    {

        private string storeAsClearTextField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string storeAsClearText
        {
            get
            {
                return this.storeAsClearTextField;
            }
            set
            {
                this.storeAsClearTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupPropertiesConnectionSettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupPropertiesGatewaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupPropertiesRemoteDesktop
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupPropertiesLocalResources
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupPropertiesSecuritySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupPropertiesDisplaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroup
    {

        private RDCManFileGroupGroupProperties propertiesField;

        private RDCManFileGroupGroupServer[] serverField;

        /// <remarks/>
        public RDCManFileGroupGroupProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("server")]
        public RDCManFileGroupGroupServer[] server
        {
            get
            {
                return this.serverField;
            }
            set
            {
                this.serverField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupProperties
    {

        private string nameField;

        private string expandedField;

        private object commentField;

        private RDCManFileGroupGroupPropertiesLogonCredentials logonCredentialsField;

        private RDCManFileGroupGroupPropertiesConnectionSettings connectionSettingsField;

        private RDCManFileGroupGroupPropertiesGatewaySettings gatewaySettingsField;

        private RDCManFileGroupGroupPropertiesRemoteDesktop remoteDesktopField;

        private RDCManFileGroupGroupPropertiesLocalResources localResourcesField;

        private RDCManFileGroupGroupPropertiesSecuritySettings securitySettingsField;

        private RDCManFileGroupGroupPropertiesDisplaySettings displaySettingsField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string expanded
        {
            get
            {
                return this.expandedField;
            }
            set
            {
                this.expandedField = value;
            }
        }

        /// <remarks/>
        public object comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupPropertiesLogonCredentials logonCredentials
        {
            get
            {
                return this.logonCredentialsField;
            }
            set
            {
                this.logonCredentialsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupPropertiesConnectionSettings connectionSettings
        {
            get
            {
                return this.connectionSettingsField;
            }
            set
            {
                this.connectionSettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupPropertiesGatewaySettings gatewaySettings
        {
            get
            {
                return this.gatewaySettingsField;
            }
            set
            {
                this.gatewaySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupPropertiesRemoteDesktop remoteDesktop
        {
            get
            {
                return this.remoteDesktopField;
            }
            set
            {
                this.remoteDesktopField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupPropertiesLocalResources localResources
        {
            get
            {
                return this.localResourcesField;
            }
            set
            {
                this.localResourcesField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupPropertiesSecuritySettings securitySettings
        {
            get
            {
                return this.securitySettingsField;
            }
            set
            {
                this.securitySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupPropertiesDisplaySettings displaySettings
        {
            get
            {
                return this.displaySettingsField;
            }
            set
            {
                this.displaySettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupPropertiesLogonCredentials
    {

        private string userNameField;

        private string domainField;

        private RDCManFileGroupGroupPropertiesLogonCredentialsPassword passwordField;

        private string inheritField;

        /// <remarks/>
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupPropertiesLogonCredentialsPassword password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupPropertiesLogonCredentialsPassword
    {

        private string storeAsClearTextField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string storeAsClearText
        {
            get
            {
                return this.storeAsClearTextField;
            }
            set
            {
                this.storeAsClearTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupPropertiesConnectionSettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupPropertiesGatewaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupPropertiesRemoteDesktop
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupPropertiesLocalResources
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupPropertiesSecuritySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupPropertiesDisplaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServer
    {

        private string nameField;

        private string displayNameField;

        private object commentField;

        private RDCManFileGroupGroupServerLogonCredentials logonCredentialsField;

        private RDCManFileGroupGroupServerConnectionSettings connectionSettingsField;

        private RDCManFileGroupGroupServerGatewaySettings gatewaySettingsField;

        private RDCManFileGroupGroupServerRemoteDesktop remoteDesktopField;

        private RDCManFileGroupGroupServerLocalResources localResourcesField;

        private RDCManFileGroupGroupServerSecuritySettings securitySettingsField;

        private RDCManFileGroupGroupServerDisplaySettings displaySettingsField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        public object comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupServerLogonCredentials logonCredentials
        {
            get
            {
                return this.logonCredentialsField;
            }
            set
            {
                this.logonCredentialsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupServerConnectionSettings connectionSettings
        {
            get
            {
                return this.connectionSettingsField;
            }
            set
            {
                this.connectionSettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupServerGatewaySettings gatewaySettings
        {
            get
            {
                return this.gatewaySettingsField;
            }
            set
            {
                this.gatewaySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupServerRemoteDesktop remoteDesktop
        {
            get
            {
                return this.remoteDesktopField;
            }
            set
            {
                this.remoteDesktopField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupServerLocalResources localResources
        {
            get
            {
                return this.localResourcesField;
            }
            set
            {
                this.localResourcesField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupServerSecuritySettings securitySettings
        {
            get
            {
                return this.securitySettingsField;
            }
            set
            {
                this.securitySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupServerDisplaySettings displaySettings
        {
            get
            {
                return this.displaySettingsField;
            }
            set
            {
                this.displaySettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServerLogonCredentials
    {

        private string userNameField;

        private string domainField;

        private RDCManFileGroupGroupServerLogonCredentialsPassword passwordField;

        private string inheritField;

        /// <remarks/>
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupGroupServerLogonCredentialsPassword password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServerLogonCredentialsPassword
    {

        private string storeAsClearTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string storeAsClearText
        {
            get
            {
                return this.storeAsClearTextField;
            }
            set
            {
                this.storeAsClearTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServerConnectionSettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServerGatewaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServerRemoteDesktop
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServerLocalResources
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServerSecuritySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupGroupServerDisplaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServer
    {

        private string nameField;

        private string displayNameField;

        private object commentField;

        private RDCManFileGroupServerLogonCredentials logonCredentialsField;

        private RDCManFileGroupServerConnectionSettings connectionSettingsField;

        private RDCManFileGroupServerGatewaySettings gatewaySettingsField;

        private RDCManFileGroupServerRemoteDesktop remoteDesktopField;

        private RDCManFileGroupServerLocalResources localResourcesField;

        private RDCManFileGroupServerSecuritySettings securitySettingsField;

        private RDCManFileGroupServerDisplaySettings displaySettingsField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        public object comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupServerLogonCredentials logonCredentials
        {
            get
            {
                return this.logonCredentialsField;
            }
            set
            {
                this.logonCredentialsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupServerConnectionSettings connectionSettings
        {
            get
            {
                return this.connectionSettingsField;
            }
            set
            {
                this.connectionSettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupServerGatewaySettings gatewaySettings
        {
            get
            {
                return this.gatewaySettingsField;
            }
            set
            {
                this.gatewaySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupServerRemoteDesktop remoteDesktop
        {
            get
            {
                return this.remoteDesktopField;
            }
            set
            {
                this.remoteDesktopField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupServerLocalResources localResources
        {
            get
            {
                return this.localResourcesField;
            }
            set
            {
                this.localResourcesField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupServerSecuritySettings securitySettings
        {
            get
            {
                return this.securitySettingsField;
            }
            set
            {
                this.securitySettingsField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupServerDisplaySettings displaySettings
        {
            get
            {
                return this.displaySettingsField;
            }
            set
            {
                this.displaySettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServerLogonCredentials
    {

        private string userNameField;

        private string domainField;

        private RDCManFileGroupServerLogonCredentialsPassword passwordField;

        private string inheritField;

        /// <remarks/>
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        public RDCManFileGroupServerLogonCredentialsPassword password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServerLogonCredentialsPassword
    {

        private string storeAsClearTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string storeAsClearText
        {
            get
            {
                return this.storeAsClearTextField;
            }
            set
            {
                this.storeAsClearTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServerConnectionSettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServerGatewaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServerRemoteDesktop
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServerLocalResources
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServerSecuritySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RDCManFileGroupServerDisplaySettings
    {

        private string inheritField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
            }
        }
    }



}
