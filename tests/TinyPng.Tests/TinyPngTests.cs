﻿using System.Threading.Tasks;
using Xunit;

namespace TinyPngApi.Tests
{
    public class TinyPngTests
    {
        const string apiKey = "lolwat";

        [Fact(Skip ="integration")]
        public async Task Test()
        {
            var pngx = new TinyPng(apiKey);

            var result = await pngx.Compress("Resources/cat.jpg");

            Assert.Equal(15423, result.Output.Size);

            using (var png = new TinyPng("apiKey"))
            {
                await (await png.Compress("pathToFile")).SaveImageToDisk("PathToSave");
            }

        }
    }
}