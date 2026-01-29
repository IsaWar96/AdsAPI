# AdsAPI
Isak, Arnell, Evan

## API Endpoints
- `GET /api/ad/{lon}/{lat}`: Returnerar reklam för staden baserat på {lon} och {lat}.

JSON-svar:
```json
{ 
  "title": "Malmö FF",
  "description": "Malmös nya matchtröja!!",
  "imgUrl": "ads/malmoff.jpg",
  "htmlUrl": "ads/malmoff.html"

}