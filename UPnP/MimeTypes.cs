﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace UPnP
{
    /// <summary>
    /// Mime type collection
    /// </summary>
    [XmlRoot("mimeTypes")]
    public class MimeTypes
    {
        /// <summary>
        /// Gets or sets the list of the mime types
        /// </summary>
        [XmlElement("mimeType")]
        public List<MimeType> Collection { get; set; }
    }
}
