<?php
session_start();

//Include Google client library 
include_once 'src/Google_Client.php';
include_once 'src/contrib/Google_Oauth2Service.php';

/*
 * Configuration and setup Google API
 */
$clientId = '787536089608-3rp3bjb2hjq88lc0d034hj6vdl5v6ccr.apps.googleusercontent.com'; //Google client ID
$clientSecret = '84d72ed1uQG3cqJpgc2tTzCT'; //Google client secret
$redirectURL = 'http://localhost:1234/myWebLogin/index.php'; //Callback URL

//Call Google API
$gClient = new Google_Client();
$gClient->setApplicationName('myWebLogin');
$gClient->setClientId($clientId);
$gClient->setClientSecret($clientSecret);
$gClient->setRedirectUri($redirectURL);

$google_oauthV2 = new Google_Oauth2Service($gClient);
?>