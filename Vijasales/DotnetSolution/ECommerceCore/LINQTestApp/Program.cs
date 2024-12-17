// See https://aka.ms/new-console-template for more informati
using LINQTestApp;





using (var ctx = new CollectionContext<Delivery>("VsShipments"))
{

    var users =  from user
        in ctx.Users select user;

    foreach( var user in users)
    {
        Console.WriteLine(user.Status);
    }
    Console.ReadLine();
}










