$('document').ready(function () {
    $hiddenInput = $('#bstree-data')
    $('#mytree').bstree({
        dataSource: $hiddenInput,
        initValues: $hiddenInput.data('ancestors'),
        onDataPush: function (values) {
            var def = '<strong class="pull-left">Values:&nbsp;</strong>'
            for (var i in values) {
                def += '<span class="pull-left">' + values[i] + '&nbsp;</span>'
            }
            $('#status').html(def)
        },
        updateNodeTitle: function (node, title) {
            return '[' + node.attr('data-id') + '] ' + title + ' (' + node.attr('data-level') + ')'
        }
    })
})


var _gaq = _gaq || [];
_gaq.push(['_setAccount', 'UA-36251023-1']);
_gaq.push(['_setDomainName', 'jqueryscript.net']);
_gaq.push(['_trackPageview']);

(function () {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
})();
