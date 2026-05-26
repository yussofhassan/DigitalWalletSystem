using System;

namespace DWM_v0
{
    internal static class Session
    {
        // =========================
        // Current Logged-in User
        // =========================
        public static User CurrentUser { get; set; }

        // =========================
        // Clear Session (Logout)
        // =========================
        public static void Clear()
        {
            CurrentUser = null;
        }

        // =========================
        // Check if User is Logged In
        // =========================
        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}