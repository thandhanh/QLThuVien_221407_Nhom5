// File: BusinessLogicLayer/Factories/SachFactory.cs
using BusinessLogicLayer.Models;

public abstract class SachFactory
{
    public abstract Sach CreateSach();
}

public class SachGiaoKhoaFactory : SachFactory
{
    public override Sach CreateSach()
    {
        return new SachGiaoKhoa();
    }
}

public class SachThamKhaoFactory : SachFactory
{
    public override Sach CreateSach()
    {
        return new SachThamKhao();
    }
}