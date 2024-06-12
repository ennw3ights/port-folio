namespace Infrastructure.Services.DataStore.Common.Abstractions.Services;

public interface IDialogServiceHandler
{
    Task<DialogResult> ShowDialog();
}
