﻿using System.Configuration;

namespace Owasp.Esapi.Configuration
{
    /// <summary>
    /// The ConditionElement Configuration Element.
    /// </summary>
    public partial class ConditionElement : ConfigurationElement
    {
        #region Name Property

        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        internal const string NamePropertyName = "name";

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [ConfigurationProperty(NamePropertyName, IsRequired = true, IsKey = true, IsDefaultCollection = false)]
        public string Name
        {
            get
            {
                return (string)base[NamePropertyName];
            }
            set
            {
                base[NamePropertyName] = value;
            }
        }

        #endregion

        #region Type Property

        /// <summary>
        /// The XML name of the <see cref="Type"/> property.
        /// </summary>
        internal const string TypePropertyName = "type";

        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [ConfigurationProperty(TypePropertyName, IsRequired = true, IsKey = false, IsDefaultCollection = false)]
        public string Type
        {
            get
            {
                return (string)base[TypePropertyName];
            }
            set
            {
                base[TypePropertyName] = value;
            }
        }

        #endregion

        #region properties Property

        /// <summary>
        /// The XML name of the <see cref="properties"/> property.
        /// </summary>
        internal const string PropertiesPropertyName = "properties";

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [ConfigurationProperty(PropertiesPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public PropertyCollection Properties
        {
            get
            {
                return (PropertyCollection)base[PropertiesPropertyName];
            }
            set
            {
                base[PropertiesPropertyName] = value;
            }
        }

        #endregion

    }

    /// <summary>
    /// A collection of ConditionElement instances.
    /// </summary>
    [ConfigurationCollection(typeof(ConditionElement), CollectionType = ConfigurationElementCollectionType.BasicMapAlternate, AddItemName = ConditionCollection.ConditionElementPropertyName)]
    public partial class ConditionCollection : ConfigurationElementCollection
    {
        #region Constants

        /// <summary>
        /// The XML name of the individual <see cref="ConditionElement"/> instances in this collection.
        /// </summary>
        internal const string ConditionElementPropertyName = "conditionElement";

        #endregion

        #region Overrides

        /// <summary>
        /// Gets the type of the <see cref="ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="ConfigurationElementCollectionType"/> of this collection.</returns>
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }

        /// <summary>
        /// Indicates whether the specified <see cref="ConfigurationElement"/> exists in the <see cref="ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>. The default is <see langword="false"/>.
        /// </returns>
        protected override bool IsElementName(string elementName)
        {
            return (elementName == ConditionElementPropertyName);
        }

        /// <summary>
        /// Gets the element key for a specified configuration element when overridden in a derived class.
        /// </summary>
        /// <param name="element">The <see cref="ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="ConfigurationElement"/>.
        /// </returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConditionElement)element).Name;
        }

        /// <summary>
        /// When overridden in a derived class, creates a new <see cref="ConfigurationElement"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="ConfigurationElement"/>.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConditionElement();
        }

        #endregion

        #region Indexer

        /// <summary>
        /// Gets the <see cref="ConditionElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="ConditionElement"/> to retrieve</param>
        public ConditionElement this[int index]
        {
            get
            {
                return (ConditionElement)this.BaseGet(index);
            }
        }

        #endregion

        #region Add

        /// <summary>
        /// Adds the specified <see cref="ConditionElement"/>.
        /// </summary>
        /// <param name="conditionElement">The <see cref="ConditionElement"/> to add.</param>
        public void Add(ConditionElement conditionElement)
        {
            base.BaseAdd(conditionElement);
        }

        #endregion

        #region Remove

        /// <summary>
        /// Removes the specified <see cref="ConditionElement"/>.
        /// </summary>
        /// <param name="conditionElement">The <see cref="ConditionElement"/> to remove.</param>
        public void Remove(ConditionElement conditionElement)
        {
            base.BaseRemove(conditionElement);
        }

        #endregion
    }
}
