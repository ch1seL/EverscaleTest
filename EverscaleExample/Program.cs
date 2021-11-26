// See https://aka.ms/new-console-template for more information

using ch1seL.TonNet.Abstract;
using ch1seL.TonNet.Adapter.Rust;
using ch1seL.TonNet.Client;
using ch1seL.TonNet.Client.Models;
using Microsoft.Extensions.Options;

ITonClient tonClient = new TonClient(new TonClientRustAdapter(Options.Create(new TonClientOptions())));
Console.WriteLine("Hello, World!");
Console.WriteLine((await tonClient.Crypto.MnemonicFromRandom(new ParamsOfMnemonicFromRandom())).Phrase);