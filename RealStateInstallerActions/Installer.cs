using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading.Tasks;

namespace RealStateInstallerActions
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]

        public override void Commit(System.Collections.IDictionary savedState)

        {

            base.Commit(savedState);


            // This gets the named parameters passed in from your custom action
            string filePath = @"C:\ProgramData\RealState\DataBase\RealStateDataBase.db";

            // This gets the "Authenticated Users" group, no matter what it's called
            SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.AuthenticatedUserSid, null);

            // Create the rules
            FileSystemAccessRule writerule = new FileSystemAccessRule(sid, FileSystemRights.Write, AccessControlType.Allow);

            //if (!string.IsNullOrEmpty(filePath) && Directory.Exists(filePath))
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                // Get your file's ACL
                //DirectorySecurity fsecurity = Directory.GetAccessControl(filePath);
                FileSecurity fsecurity = File.GetAccessControl(filePath);

                // Add the new rule to the ACL
                fsecurity.AddAccessRule(writerule);

                // Set the ACL back to the file
                //Directory.SetAccessControl(folder, fsecurity);
                File.SetAccessControl(filePath, fsecurity);
            }

        }



        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]

        public override void Install(System.Collections.IDictionary stateSaver)

        {

            base.Install(stateSaver);

        }



        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]

        public override void Uninstall(System.Collections.IDictionary savedState)

        {

            base.Uninstall(savedState);

        }

    }
}
