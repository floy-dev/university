namespace stemming;

public class Stemming
{
    public static string ProcessRawWord(string word)
    {
        int rvPosition = GetRvPosition(word);
        int rv2Position = GetRv2Position(word);

        string perfectiveGerundEnding = ProcessPerfectiveGerund(word, rvPosition);
        if (!string.IsNullOrWhiteSpace(perfectiveGerundEnding))
        {
            word = word.Substring(0, word.Length - perfectiveGerundEnding.Length);
        }
        else
        {
            string reflexiveEnding = ProcessReflexive(word, rvPosition);
            if (!string.IsNullOrWhiteSpace(reflexiveEnding))
            {
                word = word.Substring(0, word.Length - reflexiveEnding.Length);
            }

            string complexEnding = ProcessAdjectivalVerbNounEnding(word, rvPosition);
            if (!string.IsNullOrWhiteSpace(complexEnding))
            {
                word = word.Substring(0, word.Length - complexEnding.Length);
            }
        }

        if (word.EndsWith('и') && word.Length - 1 >= rvPosition)
        {
            word = word.Substring(0, word.Length - 1);
        }

        string derivationalEnding = ProcessDerivational(word, rv2Position);
        if (!string.IsNullOrWhiteSpace(derivationalEnding))
        {
            word = word.Substring(0, word.Length - derivationalEnding.Length);
        }

        word = ProcessLastEndings(word, rvPosition);

        return word;
    }

    static string ProcessLastEndings(string word, int rvPosition)
    {
        if (word.EndsWith("нн") && word.Length - 1 >= rvPosition)
        {
            return word.Substring(0, word.Length - 1);
        }

        string superlativeEnding = ProcessSuperlative(word, rvPosition);
        if (!string.IsNullOrWhiteSpace(superlativeEnding))
        {
            word = word.Substring(0, word.Length - superlativeEnding.Length);

            if (word.EndsWith("нн") && word.Length - 1 >= rvPosition)
            {
                return word.Substring(0, word.Length - 1);
            }

            return word;
        }

        if (word.EndsWith("ь") && word.Length - 1 >= rvPosition)
        {
            return word.Substring(0, word.Length - 1);
        }

        return word;
    }

    static string ProcessSuperlative(string word, int rvPosition)
    {
        string[] superlative =
        [
            "ейш", "ейше"
        ];

        return SearchLongestEnding(word, superlative, rvPosition);
    }

    static string ProcessDerivational(string word, int rv2Position)
    {
        string[] derivational =
        [
            "ост", "ость"
        ];

        return SearchLongestEnding(word, derivational, rv2Position);
    }

    static string ProcessAdjectivalVerbNounEnding(string word, int rvPosition)
    {
        string adjectivalEnding = ProcessAdjectival(word, rvPosition);
        if (!string.IsNullOrWhiteSpace(adjectivalEnding))
        {
            return adjectivalEnding;
        }

        string verbEnding = ProcessVerb(word, rvPosition);
        if (!string.IsNullOrWhiteSpace(verbEnding))
        {
            return verbEnding;
        }

        string nounEnding = ProcessNoun(word, rvPosition);
        if (!string.IsNullOrWhiteSpace(nounEnding))
        {
            return nounEnding;
        }

        return "";
    }

    static string ProcessNoun(string word, int rvPosition)
    {
        string[] nounEndings =
        [
            "а", "ев", "ов", "ие", "ье", "е", "иями", "ями", "ами", "еи", "ии",
            "и", "ией", "ей", "ой", "ий", "й", "иям", "ям", "ием", "ем", "ам", "ом",
            "о", "у", "ах", "иях", "ях", "ы", "ь", "ию", "ью", "ю", "ия", "ья", "я"
        ];

        return SearchLongestEnding(word, nounEndings, rvPosition);
    }

    static string ProcessVerb(string word, int rvPosition)
    {
        string[] verbGroup1 =
        [
            "ла", "на", "ете", "йте", "ли", "й", "л", "ем", "н", "ло", "но", "ет", "ют", "ны",
            "ть", "ешь", "нно"
        ];
        string[] verbGroup2 =
        [
            "ила", "ыла", "ена", "ейте", "уйте", "ите", "или", "ыли", "ей", "уй", "ил", "ыл",
            "им", "ым", "ен", "ило", "ыло", "ено", "ят", "ует", "уют", "ит", "ыт", "ены",
            "ить", "ыть", "ишь", "ую", "ю"
        ];

        string verbGroup1Ending = SearchLongestEndingWithComplexCondition(word, verbGroup1, rvPosition);
        string verbGroup2Ending = SearchLongestEnding(word, verbGroup2, rvPosition);

        return verbGroup1Ending.Length > verbGroup2Ending.Length ? verbGroup1Ending : verbGroup2Ending;
    }

    static string ProcessAdjectival(string word, int rvPosition)
    {
        string[] adjective =
        [
            "ее", "ие", "ые", "ое", "ими", "ыми", "ей", "ий", "ый", "ой", "ем", "им", "ым", "ом",
            "его", "ого", "ему", "ому", "их", "ых", "ую", "юю", "ая", "яя", "ою", "ею"
        ];

        string[] participleGroup1 =
        [
            "ем", "нн", "вш", "ющ", "щ"
        ];

        string[] participleGroup2 =
        [
            "ивш", "ывш", "ующ"
        ];

        string adjectiveEnding = SearchLongestEnding(word, adjective, rvPosition);

        string wordWithoutAdjective = word;
        if (!string.IsNullOrWhiteSpace(adjectiveEnding))
        {
            wordWithoutAdjective = word.Substring(0, word.Length - adjectiveEnding.Length);
        }

        string participleEndingGroup1 =
            SearchLongestEndingWithComplexCondition(wordWithoutAdjective, participleGroup1, rvPosition);
        string participleEndingGroup2 =
            SearchLongestEndingWithComplexCondition(wordWithoutAdjective, participleGroup2, rvPosition);
        string longestParticiple = participleEndingGroup1.Length > participleEndingGroup2.Length
            ? participleEndingGroup1
            : participleEndingGroup2;

        if (longestParticiple.Length > 0)
        {
            return longestParticiple + adjectiveEnding;
        }

        return adjectiveEnding;
    }


    static string ProcessReflexive(string word, int rvPosition)
    {
        string[] reflexive =
        [
            "ся", "сь"
        ];

        return SearchLongestEnding(word, reflexive, rvPosition);
    }

    static string ProcessPerfectiveGerund(string word, int rvPosition)
    {
        string[] perfective =
        [
            "в", "вши", "вшись"
        ];
        string[] gerund =
        [
            "ив", "ивши", "ившись", "ыв", "ывши", "ывшись"
        ];

        string perfectEnding = SearchLongestEndingWithComplexCondition(word, perfective, rvPosition);
        string gerundEnding = SearchLongestEnding(word, gerund, rvPosition);

        return perfectEnding.Length > gerundEnding.Length ? perfectEnding : gerundEnding;
    }

    static string SearchLongestEnding(string word, string[] endings, int rvPosition)
    {
        string longestEnding = "";

        foreach (var ending in endings)
        {
            if (word.EndsWith(ending))
            {
                int endingPosition = word.Length - ending.Length;

                if (endingPosition > rvPosition && ending.Length > longestEnding.Length)
                {
                    longestEnding = ending;
                }
            }
        }

        return longestEnding;
    }

    static string SearchLongestEndingWithComplexCondition(string word, string[] endings, int rvPosition)
    {
        string longestEnding = "";

        foreach (var ending in endings)
        {
            if (word.EndsWith(ending))
            {
                int endingPosition = word.Length - ending.Length;

                if (endingPosition - 1 >= rvPosition
                    && (word[endingPosition - 1] == 'а' || word[endingPosition - 1] == 'я')
                    && ending.Length > longestEnding.Length
                   )
                {
                    longestEnding = ending;
                }
            }
        }

        return longestEnding;
    }

    static int GetRvPosition(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (IsVowel(word[i]))
            {
                return i + 1;
            }
        }

        return word.Length;
    }

    static int GetRv1Position(string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (IsVowel(word[i]) && !IsVowel(word[i + 1]))
            {
                return i + 2;
            }
        }

        return word.Length;
    }

    static int GetRv2Position(string word)
    {
        int rv1Position = GetRv1Position(word);

        for (int i = rv1Position; i < word.Length - 1; i++)
        {
            if (IsVowel(word[i]) && !IsVowel(word[i + 1]))
            {
                return i + 2;
            }
        }

        return word.Length;
    }

    static bool IsVowel(char letter)
    {
        char[] vowels = ['а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я'];

        return vowels.Contains(letter);
    }
}