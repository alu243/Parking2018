<template lang="pug">
v-container(class="pa-0" fluid fill-height)
	v-text-field(v-model="name" :rules="nameRules" label="車號" solo style="position:absolute;z-index:500;top:18px;left:50px" required append-icon="search" @click:append="searchmap")
	l-map(ref="map" style="width: 100%;" :zoom="zoom" :center="center" :maxZoom="maxZoom" @zoomend="zoomed")
		l-tile-layer(:url="url" :attribution="attribution" :options="options" :maxZoom="maxZoom" maxNativeZoom="18")
		l-marker(:lat-lng="marker" v-if="marker")
			l-popup(:content="text")
		l-marker(v-for="(mk, i) in markers" :lat-lng="mk.latlng" :key="i" :icon="mk.icon")
			l-popup(:content="mk.text")
</template>

<script>
import { LMap, LTileLayer, LMarker, LPopup } from 'vue2-leaflet';
const L = window['L'];
export default {
	name: 'VueLeaflet',
	components: {
		LMap,
		LTileLayer,
		LMarker,
		LPopup,
	},
	data() {
		return {
			name: null,
			nameRules: [],
			zoom: 18,
			maxZoom: 20,
			options: { maxNativeZoom: 18, maxZoom: 20 },
			center: L.latLng(22.627278, 120.301435), // eslint-disable-line no-undef
			url: 'http://{s}.tile.osm.org/{z}/{x}/{y}.png',
			attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',
			marker: null,
			text: 'this is a center marker',
			markers: [],
		};
	},
	methods: {
		zoomed(event) {
			console.log(event.target._zoom); // eslint-disble-line no-console
			//alert(event.target._zoom);
		},
		searchmap() {
			this.marker = L.latLng(22.627278, 120.301435); // eslint-disable-line no-undef
			this.$http.get('/datas/park.json').then(
				(response) => {
					console.log('data is ', response.data); // eslint-disable-line no-console
					console.log('center is ', this.center.lat); // eslint-disable-line no-console
					this.markers = response.data
						.map((item) => {
							return {
								latlng: L.latLng(item.lat, item.lng),
								text: item.area + item.cell + item.road + item.grid,
								icon: L.icon.glyph({ prefix: '', glyph: 'P' }),
							};
						})
						.filter((item) => {
							return item.latlng.distanceTo(this.center) <= 300;
						});
					console.log('markers is ', L); // eslint-disable-line no-console
				},
				(error) => {
					console.log('error:', error); // eslint-disable-line no-console
				},
			);
		},
	},
	mounted() {
		// L.tileLayer('http://{s}.tile.osm.org/{z}/{x}/{y}.png', {
		// 	attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributorsssss',
		// 	maxNativeZoom: 19,
		// 	maxZoom: 19,
		// }).addTo(this.$refs.map);
	},
};
</script>

<style scoped>
</style>
