using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Strategy.Format;
using Strategy.Order;

namespace Strategy
{
    public class House
    {
        private readonly IFormatStrategy _formatter;
        private readonly IOrderStrategy _orderer;

        private readonly IEnumerable<string> _data = new List<string>() {
            "the horse and the hound and the horn that belonged to",
            "the farmer sowing his corn that kept",
            "the rooster that crowed in",
            "the morn that woke",
            "the judge all shaven and shorn that married",
            "the man all tattered and torn that kissed",
            "the maiden all forlorn that milked",
            "the cow with the crumpled horn that tossed",
            "the dog that worried",
            "the cat that killed",
            "the rat that ate",
            "the malt that lay in",
            "the house that Jack built",
        };

        public House(IFormatStrategy formatter, IOrderStrategy orderer)
        {
            _formatter = formatter;
            _orderer = orderer;

            _data = orderer.Order(_data);
            _data = _formatter.Format(_data);
        }

        public void ReciteWhole()
        {
            var lines = Enumerable.Range(1, _data.Count()).Select(i => this.GetLine(i));
            var house = string.Join("\n", lines);

            Console.WriteLine(house);
        }

        public void ReciteLine(int lineNumber)
        {
            var line = this.GetLine(lineNumber);
            Console.WriteLine(line);
        }

        private string GetLine(int lineNumber)
        {
            var phrase = this.GetPhrase(lineNumber);
            var line = $"This is {phrase}.\n";
            return line;
        }

        private string GetPhrase(int number)
        {
            var parts = this.GetParts(number);
            var phrase = string.Join("\n\t", parts);
            return phrase;
        }

        private IEnumerable<string> GetParts(int number)
        {
            var parts = _data.Skip(_data.Count() - number);
            return parts;
        }
    }
}
