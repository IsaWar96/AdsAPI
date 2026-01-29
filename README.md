# AdsAPI
Isak, Arnell, Evan

## API Endpoints
- `GET /api/ad/{lon}/{lat}`: Returnerar reklam för staden baserat på {lon} och {lat}.

JSON-svar:
```json
{ 
  "title": "Malmö FF",
  "description": "Malmös nya maychtröja!!",
  "imgUrl": "http://localhost:5112/ads/malmoff.jpg",
  "htmlUrl": "http://localhost:5112/malmoff.html"

}