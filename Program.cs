string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendations(enjoymentLevel);
string game = GetGameRecommendations(stadium);

DisplayStadiumDetails(stadium, game);

static string GetEnjoymentLevel(){
    Console.WriteLine("What enjoyment level do you want!");
    return Console.ReadLine();
}

static string GetStadiumRecommendations(string enjoymentLevel){
    string stadium = "";

    if (enjoymentLevel.ToLower() == "boring"){
        stadium = "Neyland Stadium ";
    }
    else if (enjoymentLevel.ToLower() == "average"){
         stadium = "Jordan-Hare Stadium ";
    }
    else if (enjoymentLevel.ToLower() == "fun"){
         stadium = "Tiger Stadium ";
    }
    else if (enjoymentLevel.ToLower() == "epic"){
        stadium = "Saban Field at Bryant-Denny Stadium ";
    }
    else{
        stadium = "sike thats an invalid response";
    }
    return stadium;
}

static string GetGameRecommendations(string stadium){
    string game = "";
    if (stadium == "Neyland Stadium "){
        game = "vs Kent State";
    }
    else if(stadium == "Jordan-Hare Stadium "){
        game = "vs Kentucky";
    }
    else if(stadium == "Tiger Stadium "){
        game = "vs Alabama";
    }
    else if(stadium == "Saban Field at Bryant-Denny Stadium "){
        game = "vs Auburn";
    }
    else{
        game = "";
    }
    return game;
}

static void DisplayStadiumDetails(string stadium, string game){
Console.WriteLine($"I recommend that you go to the game at\n{stadium}{game}");
}
