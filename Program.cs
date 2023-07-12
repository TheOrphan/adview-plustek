using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Inisialisasi
            var result = DeviceWrapper.LibWFX_Init();

            if (result == ENUM_LIBWFX_ERRCODE.LIBWFX_ERRCODE_SUCCESS)
            {
                Console.WriteLine("Inisialisasi berhasil");

                IntPtr deviceList;
                result = DeviceWrapper.LibWFX_GetDeviesList(out deviceList);

                if (result == ENUM_LIBWFX_ERRCODE.LIBWFX_ERRCODE_SUCCESS)
                {
                    Console.WriteLine("Mendapatkan daftar perangkat");
                }
                else
                {
                    Console.WriteLine("Gagal mendapatkan daftar perangkat");
                }

                // Hentikan program ini sebelum DeInit
                Console.WriteLine("Tekan tombol apapun untuk mengakhiri program...");
                Console.ReadKey();

                // DeInit
                result = DeviceWrapper.LibWFX_DeInit();

                if (result == ENUM_LIBWFX_ERRCODE.LIBWFX_ERRCODE_SUCCESS)
                {
                    Console.WriteLine("Deinisialisasi berhasil");
                }
                else
                {
                    Console.WriteLine("Deinisialisasi gagal");
                }
            }
            else
            {
                Console.WriteLine("Inisialisasi gagal");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi error: " + ex.Message);
        }
    }
}
