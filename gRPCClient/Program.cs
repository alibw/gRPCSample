// See https://aka.ms/new-console-template for more information

using Grpc.Core;
using gRPCClient;

Console.WriteLine("Hello, World!");
var channel = new Channel("localhost:5001", ChannelCredentials.Insecure);
var client = new Time.TimeClient(channel);
var response = client.whatTimeItIs(new
    EmptyTime()
    {
    }
);

Console.WriteLine(response.ToString());