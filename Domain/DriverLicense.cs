using System;

namespace Domain
{
    public class DriverLicense
    {   
        public int License { get;  }

        public DriverLicense(int license)
        {
            if (license <= 0) throw new ArgumentOutOfRangeException(nameof(license));
            License = license;
        }
    }
}