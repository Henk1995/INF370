using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PETSystem;

namespace PETSystem
{
    class ConnectString
    {
        // Getting Started Documentation

        /*   
             *Download die database vanaf google drive
                 - File path:
                  drive -> INF 370 -> del5 -> "inf370Reg.bacpac" 
             *Import die database in Microsoft SQL Server Management Studio ( SSMS vir kort ;D )
                 - Maak SSMS oop en regs click op databases
                 - Select Import Data-Tier Application..
                 - Select "NEXT"
                 - Select "Browse"
                 - FILE PATH BEHOORT TE WEES:
                    Downloads -> "inf370Reg.bacpac" 
                    ( Wees rustig hy dink )
                 - So iets sal wys =  "C:\Users\%JOU USER NAME%\Downloads\inf370Reg.bacpac" ( Pretty cool )
                 - Select "NEXT"
                 - "New Databse Name" = inf370Reg ( Los hom so )
                 - Select "NEXT"
                    ( Gan maak koffie... Dit kan i rukkie vat... )
                - As alles goed gegaan het sal jy kan databases in die "Object Explorer" ( LINKS IN SMSS ) kan refresh en die Database, "inf370Reg", sal daar wees.

        */


        /* HOE OM JOU CONNECTION STRING TE KRY

            *KRY LINQ OM TE WERK
                - Double-click PET_DB.dbml
                - In server explorer druk op Connect to database knoppie ( net bo die woord "AZURE" )
                - i Window maak oop. In "server name" dropdown kies jou SSMS server naam ( hy mag dalk i rukkie vries so gee hom kans )
                - in dropdown "Select or enter database name" select die imported database van die boonste stappe ( inf370Reg )
                - Links onder click "TEST CONNECTION"
                    - Hy behoort te se "connection successfull"
                - Regs onder click "ADVANCED"
                    - Heel onder is daar i textbox met klomp geskryf in. iets soos "Data Source=JOHN-MAC-WIN;Initial Catalog=inf370Reg;Integrated Security=True"
                    - Highlight en copy al daai, Click "OK"
                    - Click weer "OK"
                - Onder Data Connections in die Server Explorer sal die nuwe connection wys

            * KRY DIE SQL OM TE WERK
                - Gaan hier onder na "Almal se connection strings" en kry jou naam.
                - Paste die goed wat jy hier bo gecopy het in die "" aan die einde van die Public static string DBC in en uncomment ie lyntjie
                - Maak net seker dat al die ander mense se connection strings uitgecomment is.
                - Run die program en kyk of hy werk.
                 
        */

        // ALMAL SE CONNECTION STRINGS

        //Jan se connection string
        public static string DBC = "Data Source=LAPTOP-A6P2IDT8\\SQLEXPRESS;Initial Catalog=exportinf370;Integrated Security=True";

        //John se connection string
       // public static string DBC = "Data Source=JOHN-MAC-WIN;Initial Catalog=inf370Reg;Integrated Security=True";

        //Henk se connection string    + Copy jou goed hier in en uncomment die lyn hier onder
        //public static string DBC = "Data Source=.;Initial Catalog=inf370Reg;Integrated Security=True";


        //Sam se connection string    + Copy jou goed hier in en uncomment die lyn hier onder
        //public static string DBC = "Data Source=.;Initial Catalog=inf370Reg;Integrated Security=True";

        //Rohan se connection string    + Copy jou goed hier in en uncomment die lyn hier onder
        //public static string DBC = "Data Source=.;Initial Catalog=inf370Reg;Integrated Security=True";


        // LOS HIERDIE NET SO
        public static SqlConnection connectstring = new SqlConnection(DBC);
        //HEnk se comment
        //het goed geskuif vir test commit
        public string VIEW;
        // Henk se global int
        public static int ID;
        public static int CourseID;
        public static int InstructorID;
        //vir users
        public static string UserName;
        public static string UserID;
        public static string Name;
        public static string Surname;
        public static string Password;
        public static string Email;
        public static string Priv;
        //vir courses
        public static string CourseStringID;
        public static string CourseName;
        public static string CourseDuration;
        public static string CourseDate;
        public static string CourseType;
        //vir Supplier
        public static int SupplierID;
        public static string SupplierName;
        public static string SupplierEmail;
        public static string SupplierAddress;
        public static string SupplierPhoneNum;
        public static int SupplierBankAccount;
        public static string Suppliertype;
        //Vir Supplier Order
        public static int UnitPrice;
        //ACtive form
        public static bool ActiveForm;
    }
}
