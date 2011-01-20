/**************************************************************************
**
** This file is part of the Qt VS Add-in
**
** Copyright (c) 2011 Nokia Corporation and/or its subsidiary(-ies).
**
** Contact: Nokia Corporation (qt-info@nokia.com)
**
** Commercial Usage
**
** Licensees holding valid Qt Commercial licenses may use this file in
** accordance with the Qt Commercial License Agreement provided with the
** Software or, alternatively, in accordance with the terms contained in
** a written agreement between you and Nokia.
**
** GNU Lesser General Public License Usage
**
** Alternatively, this file may be used under the terms of the GNU Lesser
** General Public License version 2.1 as published by the Free Software
** Foundation and appearing in the file LICENSE.LGPL included in the
** packaging of this file.  Please review the following information to
** ensure the GNU Lesser General Public License version 2.1 requirements
** will be met: http://www.gnu.org/licenses/old-licenses/lgpl-2.1.html.
**
** If you are unsure which license is appropriate for your use, please
** contact the sales department at http://qt.nokia.com/contact.
**
**************************************************************************/

namespace Qt4VSAddin
{
    using System;
    using System.Globalization;
    using System.Resources;
    using System.Threading;
    using System.ComponentModel;

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class SRDescriptionAttribute : DescriptionAttribute 
    {

        private bool replaced = false;

        /// <summary>
        ///     Constructs a new sys description.
        /// </summary>
        /// <param name='description'>
        ///     description text.
        /// </param>
        public SRDescriptionAttribute(string description) : base(description) 
        {
        }

        /// <summary>
        ///     Retrieves the description text.
        /// </summary>
        /// <returns>
        ///     description
        /// </returns>
        public override string Description 
        {
            get 
            {
                if (!replaced) 
                {
                    replaced = true;
                    DescriptionValue = SR.GetString(base.Description);
                }
                return base.Description;
            }
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class SRCategoryAttribute : CategoryAttribute 
    {

        public SRCategoryAttribute(string category) : base(category) 
        {
        }

        protected override string GetLocalizedString(string value) 
        {
            return SR.GetString(value);
        }
    }

    internal sealed class SR 
    {
        static SR loader = null;
        ResourceManager resources;

        internal const string OK = "OK";
        internal const string Cancel = "Cancel";
        internal const string QtVSIntegration = "QtVSIntegration";
        internal const string CannotOpenFile = "CannotOpenFile";
        internal const string NotExistingFile = "NotExistingFile";
        internal const string Add = "Add";
        internal const string Edit = "Edit";
        internal const string Remove = "Remove";
        internal const string Delete = "Delete";
        internal static CultureInfo appCultureInfo = null;
        internal static CultureInfo defaultCultureInfo = null;

        internal SR() 
        {
            defaultCultureInfo = CultureInfo.GetCultureInfo("en");
            appCultureInfo = CultureInfo.GetCultureInfo(Connect._applicationObject.LocaleID);
            if (appCultureInfo.Name.StartsWith("en"))
                appCultureInfo = null;
            resources = new System.Resources.ResourceManager("Qt4VSAddin.StringResources", this.GetType().Assembly);
        }
        
        private static SR GetLoader() 
        {
            if (loader == null) 
            {
                lock(typeof(SR)) 
                {
                    if (loader == null) 
                    {
                        loader = new SR();
                    }
                }
            }
            
            return loader;
        }

        private static CultureInfo Culture 
        {
            get { return appCultureInfo; }
            //get { return null/*use ResourceManager default, CultureInfo.CurrentUICulture*/; }
            //get { return new CultureInfo("de"); }
        }
        
        public static ResourceManager Resources 
        {
            get 
            {
                return GetLoader().resources;
            }
        }

        public static String LanguageName
        {
            get { return Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName; }
            //get { return Culture.TwoLetterISOLanguageName; }
        }
        
        public static string GetString(string name, params object[] args) 
        {
            string res = GetString(name);
            if (args != null && args.Length > 0)
            {
                return String.Format(res, args);
            }
            else
            {
                return res;
            }
        }

        public static string GetString(string name) 
        {
            SR sys = GetLoader();
            if (sys == null)
                return null;

            string result;
            try
            {
                result = sys.resources.GetString(name, SR.Culture);
            }
            catch (Exception)
            {
                result = sys.resources.GetString(name, defaultCultureInfo);
            }

            return result;
        }
        
        public static object GetObject(string name) 
        {
            SR sys = GetLoader();
            if (sys == null)
                return null;

            object result;
            try
            {
                result = sys.resources.GetObject(name, SR.Culture);
            }
            catch (Exception)
            {
                result = sys.resources.GetObject(name, defaultCultureInfo);
            }

            return result;
        }
    }
}