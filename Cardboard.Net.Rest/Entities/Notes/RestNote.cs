using Cardboard.Notes;
using Cardboard.Users;
using Model = Cardboard.Net.Rest.API.Note;

namespace Cardboard.Rest.Notes;

public class RestNote : RestEntity<string>, INote, IUpdateable
{
    public RestNote(BaseMisskeyClient misskey, string id) : base(misskey, id) { }

    public DateTime CreatedAt { get; }
    public DateTime? DeletedAt { get; }
    public string? Text { get; }
    public string? ContentWarning { get; }
    public IUser User { get; }
    public INote? Reply { get; }
    public INote? Renote { get; }
    public bool IsHidden { get; }
    public VisibilityType Visibility { get; }
    public Task UpdateAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync()
    {
        throw new NotImplementedException();
    }
    
    public async Task MuteThreadAsync() 
        => throw new NotImplementedException();
    
    public async Task UnmuteThreadAsync()
        => throw new NotImplementedException();
    
    // TODO: Figure out what type to return
    public async Task GetRenotesAsync()
        => throw new NotImplementedException();
    
    // TODO: Figure out what type to return
    public async Task GetRepliesAsync() 
        => throw new NotImplementedException();
    
    public async Task RenoteAsync()
        => throw new NotImplementedException();
    
    public async Task UnRenoteAsync()
        => throw new NotImplementedException();
    
    public async Task ModifyAsync()
        => throw new NotImplementedException();
    
}