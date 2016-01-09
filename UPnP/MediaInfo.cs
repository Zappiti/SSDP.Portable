﻿using System.Collections.Generic;
using System.Reflection;

namespace UPnP
{
    /// <summary>
    /// Media informations
    /// </summary>
    public class MediaInfo
    {
        private IEnumerable<PropertyInfo> Properties { get; set; }

        /// <summary>
        /// Gets or sets the title of the media
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the URI for the media
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the media mime type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Replaces invalid XML characters with their valid XML equivalent
        /// </summary>
        public void XmlEscape()
        {
            if (Properties == null)
            {
                Properties = GetType().GetRuntimeProperties();
            }

            foreach (var pi in Properties)
            {
                pi.SetValue(this, WebUtility.XmlEscape(pi.GetValue(this) as string));
            }
        }
    }
}
