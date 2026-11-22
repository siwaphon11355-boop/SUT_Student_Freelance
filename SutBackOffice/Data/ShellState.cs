namespace SutBackOffice.Data;

/// <summary>Lets each page tell the shell (top bar) its breadcrumb + search placeholder.</summary>
public class ShellState
{
    public string[] Crumbs { get; private set; } = new[] { "แดชบอร์ด", "ภาพรวม" };
    public string SearchPlaceholder { get; private set; } = "ค้นหารหัสนักศึกษา หรือชื่อ-นามสกุล...";
    public event Action? Changed;

    public void Set(string[] crumbs, string searchPlaceholder = "ค้นหารหัสนักศึกษา หรือชื่อ-นามสกุล...")
    {
        Crumbs = crumbs;
        SearchPlaceholder = searchPlaceholder;
        Changed?.Invoke();
    }
}
