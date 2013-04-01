using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace PatientInformationSystem.Classes
{
    class publicClass
    {
        public static int UserId = 0;
        public static int UserType = 0;
        public static string UserName = "";

        public static int PatientID = 0;
        public static string PatientName = "";
        public static int age = 0;
        public static string DOV = "12/24/1900";
        public static string DoctorName = "";        
        public static string MobileNo = "";
        public static string LandLineNo = "";
        public static string Address = "";
        public static string Complaint = "";
        public static string ClinicalFinding = "";
        
                
        public static bool IsModification = true;
        

    }
}
