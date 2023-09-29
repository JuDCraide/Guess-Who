import json


for i in range(1, 25):
    f = open(f'./{i}.json')
    data = json.load(f)

    print(f'new Character({data["id"]}, "{data["name"]}", {data["woman"]}, {data["glasses"]}, {data["hat"]}, {data["beard"]}, {data["mustache"]}, {data["bald"]}, {data["blueEyes"]}, {data["bigNose"]}, {data["pinkCheeks"]}, Hair.{data["hairColor"]});')
        
    f.close()
