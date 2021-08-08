using System.Security.Cryptography;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace MyBenchmarks.Benchmarks
{

public class Md5VsSha256
{
    private SHA256 sha256 = SHA256.Create();
    private MD5 md5 = MD5.Create();
    private byte[] data;

    [Params(100, 1000)]
    public int N;

    [GlobalSetup]
    public void Setup()
    {
        data =  Encoding.ASCII.GetBytes("Lucas ipsum dolor sit amet wampa windu dantooine fett darth solo ewok mandalore obi-wan dantooine. Darth yavin darth skywalker skywalker. Ahsoka antilles antilles lando c-3p0 darth moff. Zabrak kenobi qui-gonn fett. Darth dantooine ewok antilles mandalorians organa maul droid jango. Jango moff antilles darth calrissian. Cade moff jabba maul yavin. Mon darth jabba jar jade tatooine jabba. Organa skywalker organa fett c-3p0 kamino chewbacca solo. Jinn jar biggs droid solo biggs fett dantooine. Chewbacca sebulba windu alderaan moff.");
    }

    [Benchmark]
    public byte[] Sha256() => sha256.ComputeHash(data);

    [Benchmark]
    public byte[] Md5() => md5.ComputeHash(data);
}

}