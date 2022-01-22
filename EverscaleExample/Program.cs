// See https://aka.ms/new-console-template for more information

using EverscaleNet.Abstract;
using EverscaleNet.Adapter.Rust;
using EverscaleNet.Client;
using EverscaleNet.Client.Models;
using EverscaleNet.Models;
using Microsoft.Extensions.Options;

IEverClient tonClient = new EverClient(new EverClientRustAdapter(Options.Create(new EverClientOptions())));
Console.WriteLine("Hello, World!");
Console.WriteLine((await tonClient.Crypto.MnemonicFromRandom(new ParamsOfMnemonicFromRandom())).Phrase);