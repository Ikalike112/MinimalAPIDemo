namespace MinimalAPIDemo;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet("/Users", GetUsers);
        app.MapGet("/Users/{id}", GetUser);
        app.MapPost("/Users", InsertUser);
        app.MapPut("/Users", UpdateUser);
        app.MapDelete("/Users", DeleteUser);
    }

    private static async Task<IResult> GetUsers(IUserData data)
    {
        return Results.Ok(await data.GetUsers());
    }

    private static async Task<IResult> GetUser(int id, IUserData data)
    {
        var results = await data.GetUser(id);
        if (results == null) return Results.NotFound();
        return Results.Ok(results);
    }
    private static async Task<IResult> InsertUser(UserModel user, IUserData data)
    {
            await data.InsertUser(user);
            return Results.Ok(data);
    }
    private static async Task<IResult> UpdateUser(UserModel user,IUserData data)
    {
        await data.UpdateUser(user);
        return Results.Ok();
    }
    private static async Task<IResult> DeleteUser(int id, IUserData data)
    {
        await data.DeleteUser(id);
        return Results.Ok();
    }

}
