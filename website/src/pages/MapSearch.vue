<template lang="pug">
v-container(class="pa-0" fluid fill-height)
	v-text-field(v-model="name" :rules="nameRules" label="車號" solo style="position:absolute;z-index:500;top:18px;left:50px" required)
	l-map(style="width: 100%;" :zoom="zoom" :center="center")
		l-tile-layer(:url="url" :attribution="attribution")
		l-marker(:lat-lng="marker")
			l-popup(:content="text")
</template>

<script>
import { LMap, LTileLayer, LMarker, LPopup } from 'vue2-leaflet'

export default {
	name: 'VueLeaflet',
	components: {
		LMap,
		LTileLayer,
		LMarker,
		LPopup
	},
	data() {
		return {
			name: null,
			nameRules: [],
			zoom: 17,
			center: L.latLng(22.627278, 120.301435), // eslint-disable-line no-undef
			url: 'http://{s}.tile.osm.org/{z}/{x}/{y}.png',
			attribution:
				'&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',
			marker: L.latLng(22.627278, 120.301435), // eslint-disable-line no-undef
			text: 'this is a markerrrr'
		}
	}
}
</script>

<style scoped>
</style>
