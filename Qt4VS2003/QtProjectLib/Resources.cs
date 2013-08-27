/****************************************************************************
**
** Copyright (C) 2012 Digia Plc and/or its subsidiary(-ies).
** Contact: http://www.qt-project.org/legal
**
** This file is part of the Qt VS Add-in.
**
** $QT_BEGIN_LICENSE:LGPL$
** Commercial License Usage
** Licensees holding valid commercial Qt licenses may use this file in
** accordance with the commercial license agreement provided with the
** Software or, alternatively, in accordance with the terms contained in
** a written agreement between you and Digia.  For licensing terms and
** conditions see http://qt.digia.com/licensing.  For further information
** use the contact form at http://qt.digia.com/contact-us.
**
** GNU Lesser General Public License Usage
** Alternatively, this file may be used under the terms of the GNU Lesser
** General Public License version 2.1 as published by the Free Software
** Foundation and appearing in the file LICENSE.LGPL included in the
** packaging of this file.  Please review the following information to
** ensure the GNU Lesser General Public License version 2.1 requirements
** will be met: http://www.gnu.org/licenses/old-licenses/lgpl-2.1.html.
**
** In addition, as a special exception, Digia gives you certain additional
** rights.  These rights are described in the Digia Qt LGPL Exception
** version 1.1, included in the file LGPL_EXCEPTION.txt in this package.
**
** GNU General Public License Usage
** Alternatively, this file may be used under the terms of the GNU
** General Public License version 3.0 as published by the Free Software
** Foundation and appearing in the file LICENSE.GPL included in the
** packaging of this file.  Please review the following information to
** ensure the GNU General Public License version 3.0 requirements will be
** met: http://www.gnu.org/copyleft/gpl.html.
**
**
** $QT_END_LICENSE$
**
****************************************************************************/

namespace Digia.Qt5ProjectLib
{
    /// <summary>
    /// Summary description for Resources.
    /// </summary>
    public class Resources
    {
        // export things
        public const string exportProHeader =
@"# ----------------------------------------------------
# This file is generated by the Qt Visual Studio Add-in.
# ------------------------------------------------------

# This is a reminder that you are using a generated .pro file.
# Remove it when you are finished editing this file.
message(""You are running qmake on a generated .pro file. This may not work!"")

";
        public const string exportSolutionHeader =
@"# ----------------------------------------------------
# This file is generated by the Qt Visual Studio Add-in.
# ------------------------------------------------------

# This is a reminder that you are using a generated .pro file.
# Remove it when you are finished editing this file.
message(""You are running qmake on a generated .pro file. This may not work!"")

";
        public const string exportPriHeader =
@"# ----------------------------------------------------
# This file is generated by the Qt Visual Studio Add-in.
# ------------------------------------------------------
";

        public const string ec_Template = "(TEMPLATE) Template.";
        public const string ec_Translations = "(TRANSLATIONS) Translation files.";
        public const string ec_rcFile = "(win32:RC_FILE) .rc file on windows.";
        public const string ec_Target = "(TARGET) Target name.";
        public const string ec_DestDir = "(DESTDIR) Destination directory.";
        public const string ec_Qt = "(QT) Additional QT options.";
        public const string ec_Config = "(CONFIG) Additional CONFIG options.";
        public const string ec_IncludePath = "(INCLUDEPATH) Additional include paths.";
        public const string ec_Libs = "(LIBS) Additional library dependencies.";
        public const string ec_PrecompiledHeader = "(PRECOMPILED_HEADER) Using precompiled headers.";
        public const string ec_DependPath = "(DEPENDPATH) Additional paths the project depends on.";
        public const string ec_Include = "Included .pri files.";
        public const string ec_Resources = "(RESOURCES) Resource files.";
        public const string ec_ObjDir = "(OBJECTS_DIR) Location where obj files are placed.";
        public const string ec_MocDir = "(MOC_DIR) Location where moc files are placed.";
        public const string ec_UiDir = "(UI_DIR) Location where ui files are compiled to.";
        public const string ec_RccDir = "(RCC_DIR) Location where qrc files are compiled to.";
        public const string ec_Defines = "(DEFINES) Additional project defines.";

        public const string qtProjectKeyword = "Qt4VS";
        public const string qtSheetKeyword = qtProjectKeyword + "PropertySheet";

        public const string uic4Command = "$(QTDIR)\\bin\\uic.exe";
        public const string moc4Command = "$(QTDIR)\\bin\\moc.exe";
        public const string rcc4Command = "$(QTDIR)\\bin\\rcc.exe";
        public const string lupdateCommand = "\\bin\\lupdate.exe";
        public const string lreleaseCommand = "\\bin\\lrelease.exe";

        #region path
        // All defined paths have to be relative to the project directory!!!

        public const string resourceDir = "Resources";

        // If those directories do not equal to the project directory
        // they have to be added to the include directories for
        // compiling!
        public const string generatedFilesDir = "GeneratedFiles";
        #endregion

        public static string msgBoxCaption = SR.GetString("Resources_QtVisualStudioIntegration");

        public const string mocDirKeyword = "MocDir";
        public const string mocOptionsKeyword = "MocOptions";
        public const string uicDirKeyword = "UicDir";
        public const string rccDirKeyword = "RccDir";
        public const string lupdateKeyword = "lupdateOnBuild";
        public const string lupdateOptionsKeyword = "lupdateOptions";
        public const string lreleaseOptionsKeyword = "lreleaseOptions";
        public const string askBeforeCheckoutFileKeyword = "askBeforeCheckoutFile";
        public const string disableCheckoutFilesKeyword = "disableCheckoutFiles";
        public const string disableAutoMocStepsUpdateKeyword = "disableAutoMocStepsUpdate";

        public const string registryRootPath = "Digia";

#if VS2005
        public const string registryPackagePath = registryRootPath + "\\Qt5VS2005";
#elif VS2008
        public const string registryPackagePath = registryRootPath + "\\Qt5VS2008";
#elif VS2010
        public const string registryPackagePath = registryRootPath + "\\Qt5VS2010";
#elif VS2012
        public const string registryPackagePath = registryRootPath + "\\Qt5VS2012";
#elif VS2013
        public const string registryPackagePath = registryRootPath + "\\Qt5VS2013";
#else
#error Unknown Visual Studio version!
#endif
        public const string registryVersionPath = registryRootPath + "\\Versions";
    }

    public class Filters
    {
        public static FakeFilter SourceFiles()
        {
            FakeFilter f = new FakeFilter();
            f.UniqueIdentifier = "{4FC737F1-C7A5-4376-A066-2A32D752A2FF}";
            f.Name = SR.GetString("Resources_SourceFiles");
            f.Filter = "cpp;cxx;c;def";
            return f;
        }

        public static FakeFilter HeaderFiles()
        {
            FakeFilter f = new FakeFilter();
            f.UniqueIdentifier = "{93995380-89BD-4b04-88EB-625FBE52EBFB}";
            f.Name = SR.GetString("Resources_HeaderFiles");
            f.Filter = "h";
            return f;
        }

        public static FakeFilter FormFiles()
        {
            FakeFilter f = new FakeFilter();
            f.UniqueIdentifier = "{99349809-55BA-4b9d-BF79-8FDBB0286EB3}";
            f.Name = SR.GetString("Resources_FormFiles");
            f.Filter = "ui";
            return f;
        }

        public static FakeFilter ResourceFiles()
        {
            FakeFilter f = new FakeFilter();
            f.UniqueIdentifier = "{D9D6E242-F8AF-46E4-B9FD-80ECBC20BA3E}";
            f.Name = SR.GetString("Resources_ResourceFiles");
            f.ParseFiles = false;
            f.Filter = "qrc;*";
            return f;
        }

        public static FakeFilter TranslationFiles()
        {
            FakeFilter f = new FakeFilter();
            f.UniqueIdentifier = "{639EADAA-A684-42e4-A9AD-28FC9BCB8F7C}";
            f.Name = SR.GetString("Resources_TranslationFiles");
            f.Filter = "ts";
            f.ParseFiles = false;
            return f;
        }

        public static FakeFilter GeneratedFiles()
        {
            FakeFilter f = new FakeFilter();
            f.UniqueIdentifier = "{71ED8ED8-ACB9-4CE9-BBE1-E00B30144E11}";
            f.Name = SR.GetString("Resources_GeneratedFiles");
            f.Filter = "moc;h;cpp";
            f.SCCFiles = false;
            return f;
        }

        public static FakeFilter OtherFiles()
        {
            FakeFilter f = new FakeFilter();
            f.UniqueIdentifier = "{B67473BF-9FA1-4674-831E-CB28F72D4791}";
            f.Name = SR.GetString("Resources_OtherFiles");
            f.Filter = "*";
            f.SCCFiles = false;
            return f;
        }

    }
}
