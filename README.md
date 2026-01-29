# AdsAPI
Isak, Arnell, Evan

## API Endpoints
- `GET /api/ad/{lon}/{lat}`: Returnerar reklam för staden baserat på {lon} och {lat}.

JSON-svar:
```json
{
    "title": "MalmöFF",
    "description": "Malmös nya maychtröja!!",
    "imageUrl": "http://localhost:5112/api/ads/malmoff.jpg",
    "linkUrl": "http://localhost:5112/api/ad/malmoff.html"
}