//ekobun tapilmasi meselesi
    if (b < d)
    {                
        a++;
        myInt = myInt * a;
        b = myInt;
        myInt = myInt / a;

        if (b % myInt2 == 0)
        {
            Console.Write("{0} ", h);
            Console.ReadLine();
        }

    }
    if (d < b)
    {
        c++;
        myInt2 = myInt2 * c;
        d = myInt2;
        myInt2 = myInt2 / c;

        if (d % myInt == 0)
        {
            Console.Write("{0} ", t);
            Console.ReadLine();
        }
        else
        {
            goto BOB;
        }

    }
    else
    {
        goto BOB;
    }

   