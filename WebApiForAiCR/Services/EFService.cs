using System.Data.Entity;

namespace WebApiForAiCR.Services;

public class EFService
{
    public async Task EFTest()
    {
        Database db = null;

        var s = db.ExecuteSqlCommand("select * from foo");
    }
}