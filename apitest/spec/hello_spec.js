var frisby = require('frisby');
var getApiUrl = function(relativePath) {
  var baseUrl = process.env['baseUrl'];
  if (!baseUrl) {
    baseUrl = 'http://localhost';
  }
  return baseUrl + relativePath;
};

frisby.create('Get greeting')
  .get(getApiUrl('/api/greeting'))
  .expectStatus(200)
.toss();