﻿# CoffeeScript
require.config
    paths:
        jquery: '//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min',
        kendo: [ '//cdn.kendostatic.com/2013.1.319/js/kendo.web.min',
                '../Scripts/kendo/2013.1.319/kendo.web.min' ],
        bootstrap: '../bootstrap.min'
    shim:
        'kendo':
            deps: ['jquery']
            exports: 'kendo'
        'bootstrap':
            deps: ['jquery']

require ['jquery', 'kendo', 'bootstrap', 'app'], (app) ->