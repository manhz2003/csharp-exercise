using System;

public class so
{
    public int num;

    public So(int n)
    {
        num = n;
    }

    public So Cong(So s2)
    {
        So s = new So(0);
        s.num = num + s2.num;
        return s;
    }

    public So Tru(So s2)
    {
        So s = new So(0);
        s.num = num - s2.num;
        return s;
    }

    public So Nhan(So s2)
    {
        So s = new So(0);
        s.num = num * s2.num;
        return s;
    }

    public So Chia(So s2)
    {
        So s = new So(0);
        s.num = num / s2.num;
        return s;
    }
}
