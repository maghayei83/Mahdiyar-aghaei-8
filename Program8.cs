using Digikala1.Model;

string address = "@D:/program";

List<Digikala> digikalas = new List<Digikala>();
string line;
using (StreamReader strread = new StreamReader(address))
{

    Console.WriteLine(strread.ReadLine());
}


 string date = "4068771,2533490,67627,51:02.0,133028,تهران,1";
string date2 = "7759076,3185842,376625,37:45.0,708440,اصفهان,1";
string date3 = "7304516,4751528,236525t,36:28.0,3110092,1کیش,";

Digikala info = new Digikala();

info.ID_Order = Convert.ToInt32(date.Split(",")[0]);
info.ID_Customer = Convert.ToInt32(date.Split(",")[1]);
info.ID_Item = Convert.ToInt32(date.Split(",")[2]);
info.DateTime_CartFinalize = date.Split(",")[3];
info.Amount_Gross_Order = Convert.ToInt32(date.Split(",")[4]);
info.city_name_fa = date.Split(",")[5];

info.ID_Order = Convert.ToInt32(date2.Split(",")[0]);
info.ID_Customer = Convert.ToInt32(date2.Split(",")[1]);
info.ID_Item = Convert.ToInt32(date2.Split(",")[2]);
info.DateTime_CartFinalize = date2.Split(",")[3];
info.Amount_Gross_Order = Convert.ToInt32(date2.Split(",")[4]);
info.city_name_fa = date2.Split(",")[5];

info.ID_Order = Convert.ToInt32(date3.Split(",")[0]);
info.ID_Customer = Convert.ToInt32(date3.Split(",")[1]);
info.ID_Item = Convert.ToInt32(date3.Split(",")[2]);
info.DateTime_CartFinalize = date3.Split(",")[3];
info.Amount_Gross_Order = Convert.ToInt32(date3.Split(",")[4]);
info.city_name_fa = date3.Split(",")[5];

info.ID_Order = Convert.ToInt32(date3.Split(",")[0]);
info.ID_Customer = Convert.ToInt32(date3.Split(",")[1]);
info.ID_Item = Convert.ToInt32(date3.Split(",")[2]);
info.DateTime_CartFinalize = date3.Split(",")[3];
info.Amount_Gross_Order = Convert.ToInt32(date3.Split(",")[4]);
info.city_name_fa = date3.Split(",")[5];

searchByUser(4068771);
searchByUser(7759076);
searchByUser(7304516);
void searchByUser(int ID_Customer)
{

    Console.WriteLine(
        digikalas
        .Where(x => x.ID_Customer == ID_Customer)
        .Select(x => x.city_name_fa)
        .FirstOrDefault()
        );
}