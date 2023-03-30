using Google.Protobuf.Collections;
using MySql.Data.Types;
using Org.BouncyCastle.Asn1.Mozilla;
using System;

public class UserDetails {

    private int _id;
    private String _fname;
    private String _lname;
    private String _email;
    private String _password;
    private String _address;
    private String _dob;
    private String _gender;

    public String current_weight { get; set; }
    public String target_weight { get; set; }
    public int primary_subscription { get; set; }
    public MapField<int, int> secondary_subscription { get; set; }

    public int id {
        get => _id;
        set => _id = value;
    }

    public String fname {
        get => _fname;
        set => _fname = value;
    }

    public String lname {
        get => _lname;
        set => _lname = value;
    }

    public String email {
        get => _email; 
        set => _email = value;
    }

    public String password {
        get => _password;
        set => _password = value;
    }

    public String address {
        get => _address;
        set => _address = value;
    }

    public String dob {
        get => _dob;
        set => _dob = value;
    }

    public String gender {
        get => _gender; 
        set => _gender = value;
    }
}
